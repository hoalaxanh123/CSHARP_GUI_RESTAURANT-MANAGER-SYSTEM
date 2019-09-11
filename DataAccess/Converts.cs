using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class Converts
    {
        public static string ToShortDateTimeStringVI(DateTime date)
        {
            string time, dates;
            time = date.Hour + ":" + date.Minute;
            dates = date.Day + "/" + date.Month + "/" + date.Year;
            return (time + " " + dates); 
        }
        public static string XoaDauPhay(string Chuoi)
        {
            string temp = Chuoi;
            int Length = temp.Length;
            for (int i = 0; i < Length; i++)
            {
                if (temp[i] == ',')
                {
                    temp = temp.Remove(i, 1);
                    i--;
                    Length--;
                }

            }
            return temp;
        }
        public static float ReturnFloat(string VietNamDong)
        {
            string temp = VietNamDong;
            temp = XoaDauPhay(temp);
            try
            {
                return float.Parse(temp);
                
            }
            catch (Exception)
            {

                return 0;
            }
        }
        public static string ChuyenDoiTienTeVietNam(float SoTien)
        {
            string test = SoTien.ToString();
            test = XoaDauPhay(test);
            try
            {
                Stack st = new Stack();
                int count = 0;
                for (int i = test.Length - 1; i >= 0; i--)
                {
                    if (count == 3)
                    {
                        st.Push(",");
                        count = 0;
                    }
                    st.Push(test[i]);
                    count++;
                }
                test = "";
                int SL = st.Count;
                for (int i = 0; i < SL; i++)
                {
                    test += st.Pop();
                }
                return test;
            }
            catch (Exception)
            {

                return "0";
            }
           
        }
        public static string ChuyenDoiTienTeVietNam(long SoTien)
        {
            string test = SoTien.ToString();
            test = XoaDauPhay(test);
            try
            {
                Stack st = new Stack();
                int count = 0;
                for (int i = test.Length - 1; i >= 0; i--)
                {
                    if (count == 3)
                    {
                        st.Push(",");
                        count = 0;
                    }
                    st.Push(test[i]);
                    count++;
                }
                test = "";
                int SL = st.Count;
                for (int i = 0; i < SL; i++)
                {
                    test += st.Pop();
                }
                return test;
            }
            catch (Exception)
            {

                return "0";
            }

        }
        public static DateTime DateTimeDotParseVI(string DateTimeString)
        {
            try
            {
                int Year = int.Parse(DateTimeString.Split(' ')[1].Split('/')[2].Trim());
                int Month = int.Parse(DateTimeString.Split(' ')[1].Split('/')[1].Trim());
                int Day = int.Parse(DateTimeString.Split(' ')[1].Split('/')[0].Trim());
                int Hour = int.Parse(DateTimeString.Split(' ')[0].Split(':')[0].Trim());
                int Minute = int.Parse(DateTimeString.Split(' ')[0].Split(':')[1].Trim());
                DateTime New = new DateTime(Year, Month, Day, Hour, Minute, 0);
                return New;
            }
            catch 
            {
                DateTime fail = new DateTime(2000, 1, 1, 1, 1, 1);
                return fail;
            }
           
        }
    }
}
