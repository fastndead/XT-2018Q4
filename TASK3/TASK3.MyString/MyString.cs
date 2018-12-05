using System;
using System.Linq;

namespace TASK3.MyString
{
    public class MyString
    {
        private char[] MainString { get; set; }
        private int Length => MainString.Length;

        public MyString(string str)
        {
            this.MainString = str.ToCharArray();
        }
        public MyString(params char[] chars)
        {
            this.MainString = chars;
        }

        public char this[int i]
        {
            get { return MainString[i]; }
            set { MainString[i] = value; }
        }

        public void Append(MyString str)
        {
            foreach (var character in str.MainString)
            {
                MainString.Append(character);
            }
        }

        public int IndexOf(int charToFind)
        {
            for (int i = 0; i < this.Length; i++)
            {
                if (this[i] == charToFind)
                {
                    return i;
                }
            }

            return -1;
        }

        public override bool Equals(object o)
        {
            if (this == (MyString)o)
            {
                return true ;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return (MainString).GetHashCode();
        }
        
        public override string ToString()
        {
            return new string(MainString);
        }
        
        

        public static MyString operator+ (MyString str1, MyString str2)
        {
            return new MyString(str1.ToString() + str2.ToString());
        }

        public static bool operator== (MyString str1, MyString str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }

            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    return false;
                }
            }

            return true;
        }
        public static bool operator!= (MyString str1, MyString str2)
        {
            if (str1.Length != str2.Length)
            {
                return true;
            }

            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    return true;
                }
            }

            return false;
        }

    }
}