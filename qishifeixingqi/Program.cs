using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qishifeixingqi
{
    class Program
    {  
        //下面数组中
       //  0表示普通
       //  1表示幸运轮盘 ◎
       //  2表示地雷★
       //  3表示暂停▲
       //  3表示时空隧道卍
        static int[] MapPoint = new int[100];
         static string[] Map = new string[100];
        static void Main(string[] args)
        {

            string[] names = new string[2];//names[0]存玩家A，names[1]the name of player B
            ShowUI();
            Console.WriteLine("Input the name of player A:");
            names[0] = Console.ReadLine();
            while ( names [0]=="")
            {
                Console.WriteLine("the name can not be empty ,input agin.");
                names[0] = Console.ReadLine();
            }
            Console.WriteLine("Input the name of player B:");
            names[1] = Console.ReadLine();
            while (names[1] == "" || names[1]==names[0])
            {
                if (names[1] == "")
                {
                    Console.WriteLine("the name can not be empty,input agin.");
                    names[1] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("the name can not be the same as A,input agin.");
                    names[1] = Console.ReadLine();
                }
            }

            Console.Clear();
            ShowUI();
            Console.WriteLine("fight begin !");
            Console.WriteLine("{0} is palyer A. ", names[0]);
            Console.WriteLine("{0} is palyer B. ", names[1]);
            Console.WriteLine("if A and B go to the same place ,show with &");
            Console.WriteLine();//j间隔一行
             MakeMap();
            DrawMap( 0, 0);

            Console.ReadKey();
         
        }

        /// <summary>
        /// use to display the game's name.
        /// </summary>
        static void ShowUI ( )
        {
            Console.WriteLine("***************************************************");
            Console.WriteLine("*                                                 *");
            Console.WriteLine("*              骑士飞行棋                         *");
            Console.WriteLine("*                                                 *");
            Console.WriteLine("***************************************************");

        }


        static void MakeMap()
        {

            int[] luckyturn = new int[6] { 4, 7, 34, 45, 67, 88 };//幸运轮盘
            int[] boom = new int[6] { 6, 9, 32, 65, 34, 84 };//地雷
            int[] pause = new int[6] { 14, 17, 44, 45, 57, 82 };//暂停
            int[] timetunnel = new int[6] { 24, 37, 54, 65, 77, 98 };//时光隧道

            for (int j = 0; j < luckyturn.Length; j++)
            {
                MapPoint[luckyturn[j]] = 1;
                Map[luckyturn [j]] = "◎";
            }

            for (int j = 0; j < boom.Length; j++)
            {
                MapPoint[boom[j]] = 2;
                Map[boom [j]] = "★";
            }
            for (int j = 0; j < pause.Length; j++)
            {
                MapPoint[pause[j]] = 3;
                Map[pause  [j]] = "▲";
            }
            for (int j = 0; j < timetunnel.Length; j++)
            {
                MapPoint[timetunnel[j]] = 4;
                Map[timetunnel  [j]] = "卍";
            }
          
            for (int i = 0; i < MapPoint.Length; i++)
            {
                if (MapPoint[i] == 0)
                    Map[i] = "□";            
            }        
        }
       


                static void DrawMap( int Apos , int Bpos )
                {
                    for (int i = 0; i < 30; i++)
                    {
                        Console.Write("{0} ", Map [i]);  //将1-30号输出，间隔一个空格。
                Console.WriteLine("*********************************************************");
                Console.WriteLine("*********************************************************");
            }
                }
    



    }
}
