using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialDevice
{
    public enum CommandType:byte
    {
        N0 = 0x0,
        N10 = 0x10,
        N11 = 0x11,
        N12 = 0x12,
        E0 = 0xE0,
        E1 = 0xE1,
        E2 = 0xE2,
        E3 = 0xE3,
        E4 = 0xE4,
    }

    public class BaseCommand
    {
        public byte[] mDeviceNumber = new byte[4];
        public byte mDataLength;
        public byte mCommand;
        public List<byte> mData = new List<byte>();
        public byte mCRC8;
        public byte mDataEndTag = 0x03;

        //这个字段不是命令数据内容
        public bool mSend2Device = false; //false:表示由设备回复给上位机的,true:上位机发送给设备的
        public CommandType mCmdType;

        public BaseCommand()
        { }

        /// <summary>
        /// 首先要保证在解析之前，传入的数据的完整性
        /// </summary>
        /// <param name="buffer"></param>
        public BaseCommand(byte[] buffer)
        {
            if (buffer != null && buffer.Length >=8)
            {
                mDeviceNumber = new byte[] { buffer[0], buffer[1], buffer[2], buffer[3] };
                mDataLength = buffer[4];
                mCommand = buffer[5];
                mCmdType = (CommandType)mCommand;
                mData.Clear();
                for (int i = 0; i < mDataLength - 3; i++)
                {
                    mData.Add(buffer[6 + i]);
                }
                mCRC8 = buffer[mDataLength+3];
                mDataEndTag = buffer[mDataLength + 4];
            }
        }

        public byte GetCRC8()
        {
            return mCRC8;
        }

        public byte GenCRC8()
        {
            byte crc8 = 0;
            foreach (var b in mDeviceNumber)
            {
                crc8 += b;
            }

            crc8 += mDataLength;
            crc8 += mCommand;

            foreach (var b in mData)
            {
                crc8 += b;
            }
            mCRC8 = crc8;
            return mCRC8;
        }

        public byte GenCRC8(List<byte> buffer)
        {
            byte crc8 = 0;
            foreach (var b in buffer)
            {
                crc8 += b;
            }
            return crc8;
        }
    }

    /// <summary>
    /// 0xE0命令：有两种不同格式，一个是发送给称重设备的，一个是由称重设备回给上位机的
    /// </summary>
    public class CommandE0 : BaseCommand
    {
        public CommandE0(bool bSend2Device = true):base()
        {
            mSend2Device = bSend2Device;
            mCommand = 0xE0;
        }

        /// <summary>
        /// 只用于从设备收取信息时构造对象
        /// </summary>
        /// <param name="bSend2Device"></param>
        /// <param name="buffer"></param>
        public CommandE0(byte[] buffer, bool bSend2Device = false) : base(buffer)
        {
            mSend2Device = bSend2Device;
            mCommand = 0xE0;
        }

        public void SetDeviceNumber(byte[] head)
        {
            if (head.Length != 4)
                return;
            mDeviceNumber[0] = head[0];
            mDeviceNumber[1] = head[1];
            mDeviceNumber[2] = head[2];
            mDeviceNumber[3] = head[3];
        }

        /// <summary>
        /// AD值必须是两个字节，低位在前，高位在后,单位：豪伏
        /// </summary>
        /// <returns></returns>
        public ushort GetAD()
        {
            ushort ad = 0;
            if (mData.Count != 2)
            {
                return 0xFFFF;//异常值
            }

            for (int i = 0; i < mData.Count; i++)
            {
                ad += (ushort)(mData[i] << i * 8);
            }
            return ad;
        }

        /// <summary>
        /// 表示读取压力传感器电压
        /// </summary>
        /// <returns></returns>
        public List<byte> GetPressureSensorCommand(byte[] head)
        {
            SetDeviceNumber(head);
            List<byte> command = new List<byte>();
            command.AddRange(mDeviceNumber);
            command.Add(0x04);//长度
            command.Add(0xE0);//命令
            command.Add(0x00);//0x00—表示读取压力传感器电压
            byte crc8 = GenCRC8(command);
            command.Add(crc8);
            command.Add(0x03);//帧尾
            return command;
        }


    }





}
