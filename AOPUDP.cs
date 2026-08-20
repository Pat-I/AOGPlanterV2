
using System.Net;
using System.Net.Sockets;
using System.Text; 

namespace AOGPlanterV2
{
    public class AOPUDP
    {
        public static UdpClient udpServer;
        private static int port = 15555; // Port to listen on
        private static AOPUDP udp;
        private float summaryPopulation = 32000.0f;
        private float summarySingulation = 96.7f;
        private float summaryDoublePercent = 1.1f;
        private float summarySkipPercent = 2.2f;


        private FormAOP mf;
        //        private OfRowCrop rc;  
        public AOPUDP(FormAOP _form)
        {
            mf = _form;
        }
        //        public AOPUDP(OfRowCrop _r)
        //        {
        //            rc = _r;
        //        }

        //*********************************************
        //Row Crop configB going out
        public class CPGN_E9
        {
            /// <Arduino configB>
            /// PGN - 233 - E9
            /// Summary
            public byte[] pgn = new byte[] { 0x80, 0x81, 0x7b, 0xE9, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0xCC };


            //where in the pgn is data
            public int[] rcConfigB = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            public int arraySpeed = 5;

            // PGN
            byte crc = 0;

            public CPGN_E9()
            {
                pgn[arraySpeed] = 0;
            }


            public void MakeCRC()
            {
                crc = 0;
                for (int i = 2; i < pgn.Length - 1; i++)
                {
                    crc += pgn[i];
                }
                pgn[pgn.Length - 1] = crc;
            }
        }

            //*********************************************
            //Row Crop array data coming in
            public class CPGN_E8
        {
            /// <skip & doubles detail>
            /// PGN - 228 - E4
            /// Summary
            public byte[] pgn = new byte[] { 0x80, 0x81, 0x7b, 0xE8, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0xCC };


            //where in the pgn is data
            public int[] rcArraySkips = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            // PGN 
            int crc = 0;

            public CPGN_E8()
            {
                rcArraySkips[1] = pgn[5] & 0b000011;  // first byte with data

            }
            public void MakeCRC()
            {
                crc = 0;
                for (int i = 2; i < pgn.Length - 1; i++)
                {
                    crc += pgn[i];
                }
                pgn[pgn.Length - 1] = (byte)crc;
            }

            public void Reset()
            {
            }
        }
        //*********************************************
        //Row Crop array data coming in
        public class CPGN_E7
        {
            /// <doubles detail>
            /// PGN - 227 - E3
            /// Summary
            public byte[] pgn = new byte[] { 0x80, 0x81, 0x7b, 0xE7, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0xCC };


            //where in the pgn is data
            public int[] rcArrayDoubles = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            // PGN 
            int crc = 0;

            public CPGN_E7()
            {
                rcArrayDoubles[1] = pgn[5] & 0b000011;  // first byte with data

            }
            public void MakeCRC()
            {
                crc = 0;
                for (int i = 2; i < pgn.Length - 1; i++)
                {
                    crc += pgn[i];
                }
                pgn[pgn.Length - 1] = (byte)crc;
            }

            public void Reset()
            {
            }
        }

        //*********************************************
        //Row Crop data coming in
        public class CPGN_E6
        {
            /// <summary>
            /// PGN - 230 - E6
            /// Row data 1 to 8 in [6]
            /// Row data 9 to 16 in [7]
            /// </summary>
            public byte[] pgn = new byte[] { 0x80, 0x81, 0x7b, 0xE6, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0xCC };


            //where in the pgn is data
            public int[] rcStatus = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };



            // PGN 
            int crc = 0;

            public CPGN_E6()
            {
                rcStatus[3] = pgn[5] & 0b000011;  // first byte with data
                pgn[5] = ((byte)(pgn[5] >> 2));
                rcStatus[2] = pgn[5] & 0b000011;



            }
            public void MakeCRC()
            {
                crc = 0;
                for (int i = 2; i < pgn.Length - 1; i++)
                {
                    crc += pgn[i];
                }
                pgn[pgn.Length - 1] = (byte)crc;
            }

            public void Reset()
            {
            }
        }

        //*********************************************
        //*********************************************
        //Row Crop data coming in
        public class CPGN_E5
        {
            /// <summary>
            /// PGN - 229 - E5
            /// Row crop summary population, etc.
            /// </summary>
            public byte[] pgn = new byte[] { 0x80, 0x81, 0x7b, 0xE5, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0xCC };


            //where in the pgn is data
            public int[] rcSummary = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };



            // PGN 
            int crc = 0;

            public CPGN_E5()
            {
                rcSummary[3] = pgn[5] & 0b000011;  // first byte with data
                pgn[5] = ((byte)(pgn[5] >> 2));
                rcSummary[2] = pgn[5] & 0b000011;
         
            }
            public void MakeCRC()
            {
                crc = 0;
                for (int i = 2; i < pgn.Length - 1; i++)
                {
                    crc += pgn[i];
                }
                pgn[pgn.Length - 1] = (byte)crc;
            }

            public void Reset()
            {
            }
        }
        //*********************************************
        //Row Crop data coming in
        public class CPGN_E4
        {
            /// <skip & doubles detail>
            /// PGN - 228 - E4
            /// Summary
            public byte[] pgn = new byte[] { 0x80, 0x81, 0x7b, 0xE4, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0xCC };


            //where in the pgn is data
            public int[] rcSkips = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            // PGN 
            int crc = 0;

            public CPGN_E4()
            {
                rcSkips[1] = pgn[5] & 0b000011;  // first byte with data

            }
            public void MakeCRC()
            {
                crc = 0;
                for (int i = 2; i < pgn.Length - 1; i++)
                {
                    crc += pgn[i];
                }
                pgn[pgn.Length - 1] = (byte)crc;
            }

            public void Reset()
            {
            }
        }
        //*********************************************
        //Row Crop data coming in
        public class CPGN_E3
        {
            /// <doubles detail>
            /// PGN - 227 - E3
            /// Summary
            public byte[] pgn = new byte[] { 0x80, 0x81, 0x7b, 0xE3, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0xCC };


            //where in the pgn is data
            public int[] rcDoubles = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            // PGN 
            int crc = 0;

            public CPGN_E3()
            {
                rcDoubles[1] = pgn[5] & 0b000011;  // first byte with data

            }
            public void MakeCRC()
            {
                crc = 0;
                for (int i = 2; i < pgn.Length - 1; i++)
                {
                    crc += pgn[i];
                }
                pgn[pgn.Length - 1] = (byte)crc;
            }

            public void Reset()
            {
            }
        }

        //*********************************************
        //Row Crop data coming in
        public class CPGN_E2
        {
            /// <pop by row detail>
            /// PGN - 226 - E2
            /// Summary
            public byte[] pgn = new byte[] { 0x80, 0x81, 0x7b, 0xE2, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0xCC };


            //where in the pgn is data
            public int[] rcPopByRow = { 0, 0, 0, 0, 0, 0, 0, 0 };

            // PGN 
            int crc = 0;

            public CPGN_E2()
            {
                rcPopByRow[1] = pgn[5] & 0b000011;  // first byte with data

            }
            public void MakeCRC()
            {
                crc = 0;
                for (int i = 2; i < pgn.Length - 1; i++)
                {
                    crc += pgn[i];
                }
                pgn[pgn.Length - 1] = (byte)crc;
            }

            public void Reset()
            {
            }
        }

        //*********************************************
        //Row Crop data coming in
        public class CPGN_E1
        {
            /// <PopByRow detail>
            /// PGN - 225 - E1
            /// Summary
            public byte[] pgn = new byte[] { 0x80, 0x81, 0x7b, 0xE1, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0xCC };


            //where in the pgn is data
            public int[] rcPop2ByRow = { 0, 0, 0, 0, 0, 0, 0, 0 };

            // PGN 
            int crc = 0;

            public CPGN_E1()
            {
                rcPop2ByRow[1] = pgn[5] & 0b000011;  // first byte with data

            }
            public void MakeCRC()
            {
                crc = 0;
                for (int i = 2; i < pgn.Length - 1; i++)
                {
                    crc += pgn[i];
                }
                pgn[pgn.Length - 1] = (byte)crc;
            }

            public void Reset()
            {
            }
        }

        //*********************************************
        //Row Crop config going out
        public class CPGN_E0
        {
            /// <Arduino config>
            /// PGN - 224 - E0
            /// Summary
            public byte[] pgn = new byte[] { 0x80, 0x81, 0x7b, 0xE0, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0xCC };


            //where in the pgn is data
            public int[] rcConfig = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            public int numSections = 5;
            public int targetSpeedX10 = 6;
            public int highRowWidthX10 = 7;
            public int lowRowWidthX10 = 8;
            public int highTargetPopulation = 9;
            public int lowTargetPopulation = 10;
            public int doublesFactor = 11;
            public int isMetric = 12;
            // PGN
            byte crc = 0;

            public CPGN_E0()
            {
                pgn[numSections] = 0;
                pgn[targetSpeedX10] = 0;
                pgn[lowRowWidthX10] = 0;
                pgn[highRowWidthX10] = 0;
                pgn[highTargetPopulation] = 0;
                pgn[lowTargetPopulation] = 0;
                pgn[doublesFactor] = 0;
                pgn[isMetric] = 0;
            }

            public void MakeCRC()
            {
                crc = 0;
                for (int i = 2; i < pgn.Length - 1; i++)
                {
                    crc += pgn[i];
                }
                pgn[pgn.Length - 1] = (byte)crc;
            }

            public void Reset()
            {
            }
        }
        //*********************************************
        //fertilizer config
        public class CPGN_A7
        {
            /// <Arduino config>
            /// PGN - 167 - A7
            /// Summary
            public byte[] pgn = new byte[] { 0x80, 0x81, 0x7b, 0xA7, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0xCC };


            //where in the pgn is data
            public byte[] rcConfig = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            public byte fertilizerZeroHi = 5;
            public byte fertilizerZeroLo = 6;
            public byte fertilizerWeightHi = 7;
            public byte fertilizerWeightLo = 8;
            public byte fertilizerForceOn1 = 9;
            public byte fertilizerForceOn2 = 10;
            public byte reserve6 = 11;
            public byte reserve7 = 12;
            // PGN
            byte crc = 0;

            public CPGN_A7()
            {
                pgn[fertilizerZeroHi] = 0x7F;
                pgn[fertilizerZeroLo] = 0xFF;
                pgn[fertilizerWeightHi] = 0xFF;
                pgn[fertilizerWeightLo] = 0xFF;
                pgn[fertilizerForceOn1] = 0;
                pgn[fertilizerForceOn2] = 0;
                pgn[reserve6] = 0;
                pgn[reserve7] = 0;
            }

            public void MakeCRC()
            {
                crc = 0;
                for (int i = 2; i < pgn.Length - 1; i++)
                {
                    crc += pgn[i];
                }
                pgn[pgn.Length - 1] = (byte)crc;
            }

            public void Reset()
            {
            }
        }
        //downpressure config
        public class CPGN_A5
        {
            /// <Arduino config>
            /// PGN - 165 - A5
            /// Summary
            public byte[] pgn = new byte[] { 0x80, 0x81, 0x7b, 0xA5, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0xCC };


            //where in the pgn is data
            public byte[] rcConfig = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            public byte actWeight = 5;
            public byte mainTarget = 6;
            public byte altTarget = 7;
            public byte setByte = 8;
            public byte airPressureHi = 9;
            public byte airPressureLo = 10;
            public byte actAirPressure = 11;
            public byte statusByte = 12;
            // PGN
            byte crc = 0;

            public CPGN_A5()
            {
                pgn[actWeight] = 0xFF;
                pgn[mainTarget] = 0xFF;
                pgn[altTarget] = 0xFF;
                pgn[setByte] = 0x00;
                pgn[airPressureHi] = 0xFF;
                pgn[airPressureLo] = 0xFF;
                pgn[actAirPressure] = 0xFF;
                pgn[statusByte] = 0;
            }

            public void MakeCRC()
            {
                crc = 0;
                for (int i = 2; i < pgn.Length - 1; i++)
                {
                    crc += pgn[i];
                }
                pgn[pgn.Length - 1] = (byte)crc;
            }

            public void Reset()
            {
            }
        }
        //vaccum config
        public class CPGN_A3
        {
            /// <Arduino config>
            /// PGN - 163 - A3
            /// Summary
            public byte[] pgn = new byte[] { 0x80, 0x81, 0x7b, 0xA3, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0xCC };


            //where in the pgn is data
            public byte[] rcConfig = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            public byte vaccum1ZeroHi = 5;
            public byte vaccum1ZeroLo = 6;
            public byte vaccum2ZeroHi = 7;
            public byte vaccum2ZeroLo = 8;
            public byte actVaccum1 = 9;
            public byte actVaccum2 = 10;
            public byte reserve6 = 11;
            public byte reserve7 = 12;
            // PGN
            byte crc = 0;

            public CPGN_A3()
            {
                pgn[vaccum1ZeroHi] = 0x7F;
                pgn[vaccum1ZeroLo] = 0xFF;
                pgn[vaccum2ZeroHi] = 0xFF;
                pgn[vaccum2ZeroLo] = 0xFF;
                pgn[actVaccum1] = 0xFF;
                pgn[actVaccum2] = 0xFF;
                pgn[reserve6] = 0;
                pgn[reserve7] = 0;
            }

            public void MakeCRC()
            {
                crc = 0;
                for (int i = 2; i < pgn.Length - 1; i++)
                {
                    crc += pgn[i];
                }
                pgn[pgn.Length - 1] = (byte)crc;
            }

            public void Reset()
            {
            }
        }
        //height config
        public class CPGN_A1
        {
            /// <Arduino config>
            /// PGN - 161 - A1
            /// Summary
            public byte[] pgn = new byte[] { 0x80, 0x81, 0x7b, 0xA1, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0xCC };


            //where in the pgn is data
            public byte[] rcConfig = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            public byte heightZeroHi = 5;
            public byte heightZeroLo = 6;
            public byte heightTopHi = 7;
            public byte heightTopLo = 8;
            public byte onThreshold = 9;
            public byte offThreshold = 10;
            public byte reserve6 = 11;
            public byte reserve7 = 12;
            // PGN
            byte crc = 0;

            public CPGN_A1()
            {
                pgn[heightZeroHi] = 0x7F;
                pgn[heightZeroLo] = 0xFF;
                pgn[heightTopHi] = 0xFF;
                pgn[heightTopLo] = 0xFF;
                pgn[onThreshold] = 0xFF;
                pgn[offThreshold] = 0xFF;
                pgn[reserve6] = 0;
                pgn[reserve7] = 0;
            }

            public void MakeCRC()
            {
                crc = 0;
                for (int i = 2; i < pgn.Length - 1; i++)
                {
                    crc += pgn[i];
                }
                pgn[pgn.Length - 1] = (byte)crc;
            }

            public void Reset()
            {
            }
        }

        //*********************************************
        //pgn instances

        /// <summary>
        /// rowCropData PGN - 233 - E9
        /// </summary>
        public CPGN_E9 p_233 = new CPGN_E9();
        /// <summary>
        /// rowCropData PGN - 232 - E8
        /// </summary>
        public CPGN_E8 p_232 = new CPGN_E8();
        /// <summary>
        /// rowCropData PGN - 231 - E7
        /// </summary>
        public CPGN_E7 p_231 = new CPGN_E7();
        /// <summary>
        /// rowCropData PGN - 230 - E6
        /// </summary>
        public CPGN_E6 rcData = new CPGN_E6();
        /// <summary>
        /// rowCropData PGN - 229 - E5
        /// </summary>
        public CPGN_E5 p_229 = new CPGN_E5();

        /// <summary>
        /// rowCropSkipData PGN - 228 - E4
        /// </summary>
        public CPGN_E4 p_228 = new CPGN_E4();

        /// <summary>
        /// rowCropDoublesByRow PGN - 227 - E3
        /// </summary>
        public CPGN_E3 p_227 = new CPGN_E3();

        /// <summary>
        /// rowCropPopByRow PGN - 226 - E2
        /// </summary>
        public CPGN_E2 p_226 = new CPGN_E2();

        /// <summary>
        /// rowCropPopByRow PGN - 225 - E1
        /// </summary>
        public CPGN_E1 p_225 = new CPGN_E1();
        /// <summary>
        /// rowCropConfig PGN - 228 - E0
        /// </summary>
        public CPGN_E0 p_224 = new CPGN_E0();
        /// <summary>
        /// fertilizerConfig PGN - 167 - A7
        /// </summary>
        public CPGN_A7 p_167 = new CPGN_A7();
        /// <summary>
        /// dowmpressureConfig PGN - 167 - A7
        /// </summary>
        public CPGN_A5 p_165 = new CPGN_A5();
        /// <summary>
        /// vaccumConfig PGN - 167 - A7
        /// </summary>
        public CPGN_A3 p_163 = new CPGN_A3();
        /// <summary>
        /// heightConfig PGN - 167 - A7
        /// </summary>
        public CPGN_A1 p_161 = new CPGN_A1();

        public void StartUDPServer()
        {
            new Thread(() =>
            {
                using (udpServer = new UdpClient(port))
                {
                    while (true)
                    {
                        ListenForMessages();
                    }
                }
            })
            { IsBackground = true }.Start();
 
            //        udpServer.Close(); // where would I put this?
        }
        public static int msgCount = 0;

        private void ListenForMessages()
        {
            //udp.mf.rc.rcSkips[4] = 5;  // for testing.  This works
            //while (true)
            //{
               // msgCount += 1;
               //                 UpdateLabel("XOXO");  // this test works
               //                 udp.mf.rc.rcSkips[3] = 4;
                

                try
                {
                    // Listen for UDP packets on the given port
                    IPEndPoint endPoint = new IPEndPoint(IPAddress.Loopback, 0);
                    byte[] data = udpServer.Receive(ref endPoint);
                    string receivedData = Encoding.UTF8.GetString(data);
                    msgCount += 1;
                  // UpdateLabel("123");  // works if AgOpenGPS is started
//                    mf.rc.rcSkips[5] = 6;  // likewise

                    if (data.Length > 4 && data[0] == 0x80 && data[1] == 0x81)
                    {
                        int Length = Math.Max((data[4]) + 5, 5);
                        if (data.Length > Length)
                        {
                            byte CK_A = 0;
                            for (int j = 2; j < Length; j++)
                            {
                                CK_A += data[j];
                            }

                            if (data[Length] != (byte)CK_A)
                            {
                                //return;
                            }
                        }
                        else
                        {
                            return;
                        }
                        switch (data[3])
                        {
                        ////height
                        case 160:
                            {
                                mf.rc.heightAdc = (ushort)((data[5] << 8) + data[6]);
                                mf.rc.heightVoltage = mf.rc.heightAdc * mf.rc.adcToVoltage;
                                mf.rc.planterHeight = data[7];
                                mf.rc.planterOnThreashold = data[9];
                                mf.rc.planterOffThreashold = data[10];
                                break;
                            }
                        ////vaccum
                        case 162:
                            {
                                mf.rc.vaccum1Adc = (ushort)((data[5] << 8) + data[6]);
                                mf.rc.vaccum2Adc = (ushort)((data[7] << 8) + data[8]);
                                mf.rc.vaccum1Voltage = ((data[5] << 8) + data[6]) * mf.rc.adcToVoltage;
                                mf.rc.vaccum2Voltage = ((data[7] << 8) + data[8]) * mf.rc.adcToVoltage;
                                mf.rc.vaccum1inWC = (data[9] - 5) / 10.0;
                                mf.rc.vaccum2inWC = (data[10] - 5) / 10.0;
                                break;
                            }
                        ////downpressure
                        case 164:
                            {
                                mf.rc.downforceKgSensor1 = (short)(data[5] - 5);
                                mf.rc.downforceKgSensor2 = (short)(data[6] - 5);
                                mf.rc.downforceKgSensor3 = (short)(data[7] - 5);
                                mf.rc.airPressureAdc = (ushort)((data[9] << 8) + data[10]);
                                mf.rc.airPressureVoltage = ((data[9] << 8) + data[10]) * mf.rc.adcToVoltage;
                                mf.rc.airPressurePSI = (data[11] - 5);
                                mf.rc.receivingDownpressureStatus = data[12];
                                mf.rc.airPressurePSIaveraged = mf.rc.airPressurePSIaveraged * 0.4 + mf.rc.airPressurePSI * 0.6;
                                break;
                            }
                        ////fertilizer
                        case 166:
                            {
                                mf.rc.fertilizerWeight = (short)((data[5] << 8) + data[6]);
                                mf.rc.fertilizerActualPosition = data[7];
                                mf.rc.fertilizerSetPosition = data[9];
                                mf.rc.fertilizerForcedPosition = data[11];
                                break;
                            }
                        //// Singulation by row//// USED by Pat's INO
                        case 205:
                            {
                                int popIndex = 7;
                                for (int i = 5; i < 13; i++)
                                {
                                    popIndex += 1;
                                    mf.rc.rcSingulationPercent[popIndex] = data[i];
                                }
                                break;
                            }
                        //// PSingulation by row//// USED by Pat's INO
                        case 204:
                            {
                                int popIndex = -1;
                                for (int i = 5; i < 13; i++)
                                {
                                    popIndex += 1;
                                    mf.rc.rcSingulationPercent[popIndex] = data[i];
                                }
                                break;
                            }
                        //// Population by row by spacing//// USED by Pat's INO
                        case 202:
                            {
                                int popIndex = 7;
                                for (int i = 5; i < 13; i++)
                                {
                                    popIndex += 1;
                                    if (data[i] > 0 && mf.rc.fbRowWidth > 0.1f)
                                        mf.rc.rcPopulation[popIndex] = 1000000000f / (data[i] * mf.rc.fbRowWidth); // row width in cm
                                    else mf.rc.rcPopulation[popIndex] = 0f;

                                        mf.rc.rcPopulationPercent[popIndex] = (mf.rc.rcPopulation[popIndex] * 100f / Properties.Settings.Default.setPlanterTargetPopulation) - 100f;
                                    if (mf.rc.rcPopulationPercent[popIndex] < -15f) mf.rc.rcPopulationPercent[popIndex] = -15f;
                                    if (mf.rc.rcPopulationPercent[popIndex] > 15f) mf.rc.rcPopulationPercent[popIndex] = 15f;

                                }
                                break;
                            }
                        //// Population by row by spacing//// USED by Pat's INO
                        case 203:
                            {
                                int popIndex = -1;
                                for (int i = 5; i < 13; i++)
                                {
                                    popIndex += 1;
                                    if (data[i] > 0 && mf.rc.fbRowWidth > 0.1f)
                                        mf.rc.rcPopulation[popIndex] = 1000000000f / (data[i] * mf.rc.fbRowWidth); // row width in cm
                                    else mf.rc.rcPopulation[popIndex] = 0f;
                                    mf.rc.rcPopulationPercent[popIndex] = (mf.rc.rcPopulation[popIndex] * 100f / Properties.Settings.Default.setPlanterTargetPopulation) - 100f;
                                    if (mf.rc.rcPopulationPercent[popIndex] < -15f)
                                    {
                                        mf.rc.rcPopulationPercent[popIndex] = -15f;
                                        //if (Properties.Settings.Default.setPlanterAlarm_Active) mf.sounds.sndDisconnected.Play();
                                    }
                                    if (mf.rc.rcPopulationPercent[popIndex] > 15f) mf.rc.rcPopulationPercent[popIndex] = 15f;
                                }
                                break;
                            }
                        //// Feedback from Arduino Planter Monitor

                        case 224:
                                {
                                    mf.rc.fbNumSections = (int)data[5];
                                    mf.rc.fbTargetSpeed = (float)data[6] / 10.0f;
                                    mf.rc.fbRowWidth = ((float)(data[7] << 8) + (float)data[8]) * .1f; // + (float)data[8]; // ; mc.actualSteerAngleChart = (Int16)((data[6] << 8) + data[5]);
                                    mf.rc.fbTargetPopulation = ((int)(data[9] << 8) + (float)data[10]) * 10.0f;
                                    mf.rc.fbDoublesFactor = (float)data[11] / 100.0f;

                                    if (data[12] == 1)
                                    {
                                        mf.rc.fbIsMetric = true;
                                    }
                                    else
                                    {
                                        mf.rc.fbIsMetric = false;
                                    }
                                    if (mf.rc.fbNumSections != Properties.Settings.Default.setPlanterNumRows ||
                                            mf.rc.fbTargetSpeed != Properties.Settings.Default.setPlanterSpeed ||
                                            Math.Abs(mf.rc.fbRowWidth - Properties.Settings.Default.setPlanterRowWidth) > .001 ||
                                            mf.rc.fbTargetPopulation != Properties.Settings.Default.setPlanterTargetPopulation ||
                                            mf.rc.fbDoublesFactor != Properties.Settings.Default.setPlanterDoublesFactor ||
                                            mf.rc.fbIsMetric != Properties.Settings.Default.setMenu_isMetric)
                                    {

                                        // sending data

                                        p_224.pgn[p_224.highRowWidthX10] = unchecked((byte)((int)(Properties.Settings.Default.setPlanterRowWidth * 10.0f) >> 8));
                                        p_224.pgn[p_224.lowRowWidthX10] = unchecked((byte)(int)(Properties.Settings.Default.setPlanterRowWidth * 10.0f));
                                        p_224.pgn[p_224.numSections] = (byte)Properties.Settings.Default.setPlanterNumRows;
                                        p_224.pgn[p_224.targetSpeedX10] = (byte)(Properties.Settings.Default.setPlanterSpeed * 10.0f);
                                        p_224.pgn[p_224.highTargetPopulation] = unchecked((byte)((int)(Properties.Settings.Default.setPlanterTargetPopulation / 10) >> 8));
                                        p_224.pgn[p_224.lowTargetPopulation] = unchecked((byte)(int)(Properties.Settings.Default.setPlanterTargetPopulation / 10));
                                        p_224.pgn[p_224.doublesFactor] = unchecked((byte)(int)(Properties.Settings.Default.setPlanterDoublesFactor * 100.0f));
                                        if (Properties.Settings.Default.setMenu_isMetric)
                                        {
                                            p_224.pgn[p_224.isMetric] = unchecked((byte)(int)1);
                                        }
                                        else
                                        {
                                            p_224.pgn[p_224.isMetric] = unchecked((byte)(int)0);
                                        }
                                        p_224.MakeCRC();
                                        SendPgnToLoop(p_224.pgn);

                                        //     TimedMessageBox(2000, gStr.gsAutoSteerPort, "Settings Sent To Planter Monitor Module");
                                    } // end case
                                    break;
                                }
                            
                            //// Population by row //// USED by Outfarming INO
                            case 225:
                                {
                                    int popIndex = 7;
                                    for (int i = 5; i < 13; i++)
                                    {
                                        popIndex += 1;
                                        //	if (data[i] < 0) data[i] = 250;  // occurs with overflow situation
                                        //	rc.rcPopulationPercent[popIndex] = (data[i] * 100000f / (float.Parse(Properties.Settings.Default.setPlanterTargetPopulation))) - 100f;
                                        mf.rc.rcPopulation[popIndex] = data[i] * 1000f;
                                        mf.rc.rcPopulationPercent[popIndex] = (data[i] * 100000f / Properties.Settings.Default.setPlanterTargetPopulation) - 100f;
                                        if (mf.rc.rcPopulationPercent[popIndex] < -15f) mf.rc.rcPopulationPercent[popIndex] = -15f;
                                        if (mf.rc.rcPopulationPercent[popIndex] > 115f) mf.rc.rcPopulationPercent[popIndex] = 115f;

                                    }
                                    break;
                                }
                            //// Population by row //// USED by Outfarming INO
                            case 226:
                                {
                                    int popIndex = -1;
                                    for (int i = 5; i < 13; i++)
                                    {
                                        popIndex += 1;
                                        //	if (data[i] < 0) data[i] = 250;  // occurs with overflow situation
                                        mf.rc.rcPopulation[popIndex] = data[i] * 1000f;
                                        mf.rc.rcPopulationPercent[popIndex] = (data[i] * 100000f / Properties.Settings.Default.setPlanterTargetPopulation) - 100f;
                                        if (mf.rc.rcPopulationPercent[popIndex] < -15f)
                                        {
                                            mf.rc.rcPopulationPercent[popIndex] = -15f;
                                            if (Properties.Settings.Default.setPlanterAlarm_Active) mf.sounds.sndDisconnected.Play(); 
                                        }
                                        if (mf.rc.rcPopulationPercent[popIndex] > 115f) mf.rc.rcPopulationPercent[popIndex] = 115f;
                                    }
                                    break;
                                }
                            //// Doubles by row ////
                            case 227:
                                {

                                    int doubleIndex = -2;

                                    for (int i = 5; i < 13; i++)
                                    {
                                        doubleIndex += 3;
                                        mf.rc.rcDoubles[doubleIndex] = (byte)data[i] & 0b000111;
                                        data[i] = ((byte)(data[i] >> 4));
                                        doubleIndex -= 1;
                                        mf.rc.rcDoubles[doubleIndex] = (byte)data[i] & 0b000111;
                                    }
                                    break;
                                }
                            //// Skips by row ////
                            case 228:
                                {
                                    int skipIndex = -2;
                                    for (int i = 5; i < 13; i++)
                                    {
                                        skipIndex += 3;
                                        mf.rc.rcSkips[skipIndex] = (byte)data[i] & 0b000111;
                                        data[i] = ((byte)(data[i] >> 4));
                                        skipIndex -= 1;
                                        mf.rc.rcSkips[skipIndex] = (byte)data[i] & 0b000111;
                                    }
                                    break;
                                }
                            //// Row crop summary ////
                            case 229:
                                {
                                    summaryPopulation = (UInt16)((data[6] << 8) + data[5]);
                                    summaryPopulation *= 10;
                                    summarySingulation = (UInt16)((data[12] << 8) + data[11]);
                                    summarySingulation = summarySingulation / 10;
                                    summarySkipPercent = (UInt16)((data[8] << 8) + data[7]);
                                    summarySkipPercent = summarySkipPercent / 10;
                                    summaryDoublePercent = (UInt16)((data[10] << 8) + data[9]);
                                    summaryDoublePercent = summaryDoublePercent / 10;
                                    mf.rc.sumSkipPercent = summarySkipPercent;
                                    mf.rc.sumDoublePercent = summaryDoublePercent;
                                    mf.rc.sumPopulation = summaryPopulation;
                                    mf.rc.sumSingulation = summarySingulation;
                                    mf.rc.timeDataReceived = DateTime.Now;
                                    break;
                                }
                            ////// Row crop status by row -- sets color
                            case 230:   // test by Jim to catch row sensor state 16 rows stored in data[5] and data[6]
                                {
                                for (int i = 0; i < mf.tool.numOfSections; i++)
                                {
                                    // 1. Get the 2-bit status (from bytes 5, 6, 7, 8)
                                    int statusByteIndex = 5 + (i / 4);
                                    int statusShift = (i % 4) * 2;
                                    int status = (data[statusByteIndex] >> statusShift) & 0b11;

                                    // 2. Get the override bit (from bytes 10, 11)
                                    // Row 0-7 -> byte 10, Row 8-15 -> byte 11
                                    int overrideByteIndex = 10 + (i / 8);
                                    int overrideBit = (data[overrideByteIndex] >> (i % 8)) & 0b1;

                                    // 3. Apply the logic: if bit is 1(off), status is 4(gray)
                                    if (overrideBit == 1)
                                    {
                                        status = 4;
                                    }
                                    //else if (status == 1)
                                    //{
                                        // Only play alarm if the bit was 1 AND status is 1
                                        // if (Properties.Settings.Default.setPlanterAlarm_Active) sounds.sndDisconnected.Play();
                                    //}

                                    mf.rc.rcRowStatus[i] = status;
                                }

                                // Final counter
                                mf.rc.fbFeedbackCounter = (int)data[9];

                                break;

                                }
                            //// Doubles array by row //// NOT used
                            case 232:
                                {

                                    int doubleIndex = -2;

                                    for (int i = 5; i < 13; i++)
                                    {
                                        doubleIndex += 3;
                                        mf.rc.rcArrayDoubles[doubleIndex] = (byte)data[i] & 0b000111;
                                        data[i] = ((byte)(data[i] >> 4));
                                        doubleIndex -= 1;
                                        mf.rc.rcArrayDoubles[doubleIndex] = (byte)data[i] & 0b000111;
                                    }
                                    break;
                                }
                            //// Skips array by row //// NOT used
                            case 231:
                                {
                                    int skipIndex = -2;
                                    for (int i = 5; i < 13; i++)
                                    {
                                        skipIndex += 3;
                                        mf.rc.rcArraySkips[skipIndex] = (byte)data[i] & 0b000111;
                                        data[i] = ((byte)(data[i] >> 4));
                                        skipIndex -= 1;
                                        mf.rc.rcArraySkips[skipIndex] = (byte)data[i] & 0b000111;
                                    }
                                    break;
                                }
                        }

                    }
                }
                catch (Exception ex)
                {
                    //                    Console.WriteLine($"Error receiving message: {ex.Message}");
                }
            //}
        }
        //    }

        public void SendFertilizerConfig(byte force = 0, Int16 zero = Int16.MaxValue, UInt16 weight = UInt16.MaxValue)
        {
            if (zero < 32000)
            {
                p_167.pgn[p_167.fertilizerZeroHi] = (byte)(zero >> 8);
                p_167.pgn[p_167.fertilizerZeroLo] = (byte)(zero & 0xFF);
            }
            else
            {
                p_167.pgn[p_167.fertilizerZeroHi] = 0x7F;
                p_167.pgn[p_167.fertilizerZeroLo] = 0xFF;
            }
            if (weight < 32000)
            {
                p_167.pgn[p_167.fertilizerWeightHi] = (byte)(weight >> 8);
                p_167.pgn[p_167.fertilizerWeightLo] = (byte)(weight & 0xFF);
            }
            else
            {
                p_167.pgn[p_167.fertilizerWeightHi] = 0xFF;
                p_167.pgn[p_167.fertilizerWeightLo] = 0xFF;
            }
            p_167.pgn[p_167.fertilizerForceOn1] = force;
            p_167.pgn[p_167.fertilizerForceOn2] = 0;
            p_167.pgn[p_167.reserve6] = 0;
            p_167.pgn[p_167.reserve7] = 0;

            p_167.MakeCRC();
            SendPgnToLoop(p_167.pgn);
        }

        public void SendDownpressureConfig(byte weight = byte.MaxValue, byte maintarget = byte.MaxValue, byte alttarget = byte.MaxValue, byte setByte = 0, ushort airPressZero = 6000, byte actAirPress = byte.MaxValue)
        {
            p_165.pgn[p_165.actWeight] = weight;
            p_165.pgn[p_165.mainTarget] = maintarget;
            p_165.pgn[p_165.altTarget] = alttarget;
            p_165.pgn[p_165.setByte] = setByte;
            if (airPressZero < 4096)
            {
                p_165.pgn[p_165.airPressureHi] = (byte)(airPressZero >> 8);
                p_165.pgn[p_165.airPressureLo] = (byte)(airPressZero & 0xFF);
            }
            else
            {
                p_165.pgn[p_165.airPressureHi] = 0xFF;
                p_165.pgn[p_165.airPressureLo] = 0xFF;
            }
            p_165.pgn[p_165.actAirPressure] = actAirPress;
            p_165.pgn[p_165.statusByte] = mf.rc.DownpressureStatusToSend; //use a global variable

            p_165.MakeCRC();
            SendPgnToLoop(p_165.pgn);
        }

        public void SendVaccumConfig(ushort vaccum1zero = 6000, ushort vaccum2zero = 6000, byte vac1 = byte.MaxValue, byte vac2 = byte.MaxValue)
        {
            if (vaccum1zero < 4096)
            {
                p_163.pgn[p_163.vaccum1ZeroHi] = (byte)(vaccum1zero >> 8);
                p_163.pgn[p_163.vaccum1ZeroLo] = (byte)(vaccum1zero & 0xFF);
            }
            else
            {
                p_163.pgn[p_163.vaccum1ZeroHi] = 0xFF;
                p_163.pgn[p_163.vaccum1ZeroLo] = 0xFF;
            }
            if (vaccum2zero < 4096)
            {
                p_163.pgn[p_163.vaccum2ZeroHi] = (byte)(vaccum2zero >> 8);
                p_163.pgn[p_163.vaccum2ZeroLo] = (byte)(vaccum2zero & 0xFF);
            }
            else
            {
                p_163.pgn[p_163.vaccum2ZeroHi] = 0xFF;
                p_163.pgn[p_163.vaccum2ZeroLo] = 0xFF;
            }
            p_163.pgn[p_163.actVaccum1] = vac1;
            p_163.pgn[p_163.actVaccum2] = vac2;
            p_163.pgn[p_163.reserve6] = 0;

            p_163.MakeCRC();
            SendPgnToLoop(p_163.pgn);
        }
        public void SendHeightConfig(ushort heightZero = 6000, ushort heightTop = 6000, byte onThresh = byte.MaxValue, byte offThresh = byte.MaxValue)
        {
            if (heightZero < 4096)
            {
                p_161.pgn[p_161.heightZeroHi] = (byte)(heightZero >> 8);
                p_161.pgn[p_161.heightZeroLo] = (byte)(heightZero & 0xFF);
            }
            else
            {
                p_161.pgn[p_161.heightZeroHi] = 0x7F;
                p_161.pgn[p_161.heightZeroLo] = 0xFF;
            }
            if (heightTop < 4096)
            {
                p_161.pgn[p_161.heightTopHi] = (byte)(heightTop >> 8);
                p_161.pgn[p_161.heightTopLo] = (byte)(heightTop & 0xFF);
            }
            else
            {
                p_161.pgn[p_161.heightTopHi] = 0xFF;
                p_161.pgn[p_161.heightTopLo] = 0xFF;
            }
            p_161.pgn[p_161.onThreshold] = onThresh;
            p_161.pgn[p_161.offThreshold] = offThresh;
            p_161.pgn[p_161.reserve6] = 0;
            p_161.pgn[p_161.reserve7] = 0;

            p_161.MakeCRC();
            SendPgnToLoop(p_161.pgn);
        }
        public void SendPgnToLoop(byte[] byteData)
        {
            //UdpClient client = new UdpClient();
            udpServer.Send(byteData, byteData.Length, "127.255.255.255", 17777);
        }       
    }
}



