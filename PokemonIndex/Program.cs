using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS280_Lecture1_Examples;

namespace PokemonIndex
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemons = new Pokemon();

            Console.WriteLine("請輸入寶可夢的類別");
            try
            {
                pokemons.Category = Console.ReadLine();
            }
            catch (Exception warning)
            {
                Console.WriteLine("錯誤訊息:\n" + warning.ToString());
            }
            Console.WriteLine("請輸入寶可夢的身高");
            try
            {
                pokemons.Height = float.Parse(Console.ReadLine());
            }
            catch (Exception warning)
            {
                Console.WriteLine("請輸入正確的數字。\n錯誤訊息:\n" + warning.ToString());
            }

            Console.WriteLine("請輸入寶可夢的體重");
            try
            {
                pokemons.Weight = float.Parse(Console.ReadLine());
            }
            catch (Exception warning)
            {
                Console.WriteLine("請輸入正確的數字。\n錯誤訊息:\n" + warning.ToString());
            }
            Console.WriteLine("輸入完成");
        }

        //private void CheckValue(int WNumber, string WarnMsg)
        //{
        //    string BugInfo;
        //    BugInfo = "";
        //    switch (WNumber)
        //    {
        //        case 1:
        //            BugInfo = "輸入錯誤，請輸入正確數字。\n錯誤訊息:\n" + WarnMsg;
        //            break;

        //        case 2:
        //            BugInfo = "請輸入正確的數字，勿使用小數點。\n錯誤訊息:\n" + WarnMsg;
        //            break;
    }
}