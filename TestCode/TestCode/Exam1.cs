using System;
namespace TestCode
{
    public class Exam1
    {
        public Exam1()
        {
            int[] li_list = new int[3];
            int li_1, li_2, li_3;

            li_list = getIntValues();

            if (li_list == null)
            {
                return;
            }

            /// 여기부터 코드 작성....
            ///
            li_1 = li_list[0];
            li_2 = li_list[1];
            li_3 = li_list[2];

            Console.WriteLine((li_1 + li_2) % li_3);
            Console.WriteLine(((li_1 % li_3) + (li_2 % li_3)) % li_3);
            Console.WriteLine((li_1 * li_2) % li_3);
            Console.WriteLine(((li_1 % li_3) * (li_2 % li_3)) % li_3);

        }

        int[] getIntValues()
        {
            string ls_val = string.Empty;
            string[] ls_s = new string[3];
            int[] li_val = new int[3];

            ls_val = Console.ReadLine();

            ls_s = ls_val.Split(' ');

            if (ls_s.Length != 3)
            {
                return null;
            }

            for (int i = 0; i < ls_s.Length; i++)
            {
                if (Convert.ToInt32(ls_s[i]) >= 2 && Convert.ToInt32(ls_s[i]) <= 10000)
                {
                    li_val.SetValue(Convert.ToInt16(ls_s[i]), i);
                }
                else
                {
                    Console.WriteLine("값을 다시 입력하세요");
                    getIntValues();
                }

            }
            return li_val;
        }    
    }
}
