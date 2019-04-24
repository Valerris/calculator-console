using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CalculatorApplication
{
    class Program
    {
        static void Intersaction(List<string> M1, List<string> M2)
        {
            M1.Sort(); M2.Sort();
            List<string> tempArr = new List<string>();
            int j = 0;
            for (int i = 0; i < M1.Count; i++)
	        {  
                if (j < M2.Count && M1[i] == M2[j])
                {
                    tempArr.Add(M1[i]);
                    j++;
                }
	        }
            if (tempArr.Count == 0)
                Console.Write("Пустое множество");
            else
            {
                Console.WriteLine("Result");
                foreach (string key in tempArr)
                    Console.Write(key + " ");
            }
        }
        static void Union(List<string> M1, List<string> M2)
        {
            M1.Sort(); M2.Sort();
            List<string> tempArr = new List<string>();            
            int j = 0;
            for (int i = 0; i < M1.Count; i++)
            {
                if (j < M2.Count && M1[i] == M2[j])
                {
                    j++;
                }
                else tempArr.Add(M1[i]);
            }
            foreach (string value in M2)
                tempArr.Add(value);
            if (tempArr.Count == 0)
                Console.Write("Пустое множество");
            else
            {
                Console.WriteLine("Result");
                foreach (string key in tempArr)
                    Console.Write(key + " ");
            }
        }
        static void Difference(List<string> M1, List<string> M2)
        {
            List<string> tempArr = new List<string>();
            M1.Sort(); M2.Sort();
            int j = 0;
            for (int i = 0; i < M1.Count; i++)
            {
                if (j < M2.Count && M1[i] == M2[j])
                {
                    j++;
                }
                else tempArr.Add(M1[i]);
            }
            if (tempArr.Count == 0)
                Console.Write("Пустое множество");
            else
            {
                Console.WriteLine("Result");
                foreach (string key in tempArr)
                    Console.Write(key + " ");
            }
        }

        static void SymmetricDifference(List<string> U, List<string> M1, List<string> M2)
        {
            M1.Sort(); M2.Sort();
            List<string> tempArr = new List<string>();
            int j = 0, k = 0;
            for (int i = 0; i < M1.Count; i++)
            {
                if (j < M2.Count && M1[i] == M2[j])
                {
                    j++;
                }
                else tempArr.Add(M1[i]);
            }
            foreach (string value in M2)
                tempArr.Add(value);
            for (int i = 0; i < M1.Count; i++)
            {
                if (k < M2.Count && M1[i] == M2[k])
                {
                    tempArr.Remove(M1[i]);
                    k++;
                }
            }
            if (tempArr.Count == 0)
                Console.Write("Пустое множество");
            else
            {
                Console.WriteLine("Result");
                foreach (string key in tempArr)
                    Console.Write(key + " ");
            }
        }
        static void CortesianMultiplication(List<string> U, List<string> M1, List<string> M2)
        {
            M1.Sort(); M2.Sort();
            List<string> tempArr = new List<string>();
            int j = 0, k = 0;
            for (int i = 0; i < M1.Count; i++)
            {
                if (j < M2.Count && M1[i] == M2[j])
                {
                    j++;
                }
                else tempArr.Add(M1[i]);
            }
            foreach (string value in M2)
                tempArr.Add(value);
            for (int i = 0; i < M1.Count; i++)
            {
                if (k < M2.Count && M1[i] == M2[k])
                {
                    tempArr.Remove(M1[i]);
                    k++;
                }
            }
            if (tempArr.Count == 0)
                Console.Write("Пустое множество");
            else
            {
                Console.WriteLine("Result");
                foreach (string key in tempArr)
                    Console.Write(key + " ");
            }
        }
        static void Inversion(List<string> U, List<string> M)
        {
            List<string> tempArr = new List<string>();
            M.Sort(); U.Sort();
            int j = 0;
            for (int i = 0; i < U.Count; i++)
            {
                if (j < M.Count && U[i] == M[j])
                {
                    j++;
                }
                else tempArr.Add(U[i]);
            }
            if (tempArr.Count == 0)
                Console.Write("Пустое множество");
            else
            {
                Console.WriteLine("Result");
                foreach (string key in tempArr)
                    Console.Write(key + " ");
            }
        }
        static List<string> Universal(List<string> M1, List<string> M2)
        {
            M1.Sort(); M2.Sort();
            List<string> tempArr = new List<string>();
            int j = 0;
            for (int i = 0; i < M1.Count; i++)
            {
                if (j < M2.Count && M1[i] == M2[j])
                {
                    j++;
                }
                else tempArr.Add(M1[i]);
            }
            foreach (string value in M2)
                tempArr.Add(value);
            if (tempArr.Count == 0)
                Console.Write("Пустое множество");
            return tempArr;
        }
        static void Output(List<string> M)
        {
            Console.WriteLine("Output: ");
            foreach (string item in M)
                Console.Write(item + " ");
            Console.WriteLine();
        }
        static List<string> Put()
        {
            List<string> Arr = new List<string>();
            string s, ch;
            Regex e = new Regex(@"\s+");
            Regex n = new Regex(@"\D+");
            try
            {
                do
                {
                    s = Convert.ToString(Console.ReadLine());
                    //if (n.IsMatch(s)) Console.WriteLine("! Разрешено вводить только цифры !");
                    //else 
                    if(s == "" || e.IsMatch(s)) Console.WriteLine("! Вы ничего не ввели !");
                    else Arr.Add(s);
                    Console.WriteLine("Ещё элемент? (n - для отказа; любые символы - для продолжения ввода) ");
                    ch = Convert.ToString(Console.ReadLine());
                } while (ch != "n");
            }
            catch(FormatException)
            {
                Console.WriteLine("! Неверный формат ввода !");
            }
            return Arr;
        }
        static void Main(string[] args)
        {
            List<string> U = new List<string>();
            List<string> M1 = new List<string>();
            List<string> M2 = new List<string>();
            List<string> Result = new List<string>();
            int op;
            String ch = "a";
            Console.WriteLine("Заполните 1-е множество ");
            M1 = Put();
            Console.WriteLine();
            M1.Sort();
            Console.WriteLine("Заполните 2-е множество ");
            M2 = Put();
            M2.Sort();
            U = Program.Universal(M1, M2);
            while (ch != "n")
            {
                try
                {
                Console.WriteLine("Введите номер операции: \n 1)Пересечение \n 2)Объединение \n 3)Разность \n 4)Симметрическая разность \n 5)Декартово произведение \n 6)Инверсия 1-го множества \n 7)Инверсия 2-го множества \n 8)Вывод Универсального множества \n 9)Вывод 1-го множества \n 10)Вывод 2-го множества \n 11)Exit");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1: Program.Intersaction(M1, M2); break;
                    case 2: Program.Union(M1, M2); break;
                    case 3: Program.Difference(M1, M2); break;
                    case 4: Program.SymmetricDifference(U, M1, M2); break;
                    case 5: Program.CortesianMultiplication(U, M1, M2); break;
                    case 6: Program.Inversion(U, M1); break;
                    case 7: Program.Inversion(U, M2); break;
                    case 8: Program.Output(U); break;
                    case 9: Program.Output(M1); break;
                    case 10: Program.Output(M2); break;
                    case 11: Environment.Exit(0); break;
                }
                Console.WriteLine();
                Console.WriteLine("Continue? (n - для отказа; любая клавиша - для продолжения) ");
                ch = Convert.ToString(Console.ReadLine());        
                Console.WriteLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("! Невeрный формат ввода !");
                }
            }            
            Console.ReadKey();
        }
    }
}