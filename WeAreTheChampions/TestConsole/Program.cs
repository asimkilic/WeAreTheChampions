using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddColors();
            //AddPlayers();
            //AddTeams();
            Console.WriteLine("-----------------------");
            Console.WriteLine("-----------------------");
            Print();
            Console.ReadKey();
        }
        static void Print()
        {
            using (ChampionsContext context = new ChampionsContext())
            {

                foreach (var item in context.Colors)
                {
                    Console.WriteLine($"{item.ColorName} {item.Red} {item.Green} {item.Blue}");
                }
                Console.WriteLine("-----------------------");
                foreach (var item in context.Teams)
                {
                    Console.WriteLine($"item team name: {item.TeamName}");
                   
                }
                Console.WriteLine("-----------------------");

                foreach (var item in context.Players)
                {
                    Console.WriteLine($"{item.PlayerName}");
                }
                Console.WriteLine("-----------------------");

            }

        }

        static void AddColors()
        {
            using (ChampionsContext context = new ChampionsContext())
            {
                context.Colors.AddRange(
                    new List<Color>
                    {
                    new Color{ ColorName="Deneme1",Red=120,Green=100,Blue=100},
                    new Color{ ColorName="Deneme2",Red=121,Green=110,Blue=101},
                    new Color{ ColorName="Deneme3",Red=160,Green=105,Blue=105}
                    });
                context.SaveChanges();
            }

        }
        static void AddPlayers()
        {
            using (ChampionsContext context = new ChampionsContext())
            {
                context.Players.AddRange(
                    new List<Player>
                    {
                    new Player{PlayerName="Kenan Karaman1" },
                    new Player{PlayerName="Kenan Karaman2" },
                    new Player{PlayerName="Kenan Karaman3" },
                    });
                context.SaveChanges();
            }
        }
        static void AddTeams()
        {
            using (ChampionsContext context = new ChampionsContext())
            {
                context.Teams.AddRange(
                    new List<Team>
                    {
                    new Team{
                        TeamName="International Team1",
                        Players= new List<Player>{
                            new Player{PlayerName="Kenan Karaman4" },
                            new Player{PlayerName="Kenan Karaman5" },
                            new Player{PlayerName="Kenan Karaman6" }
                        }, TeamColors = new List<TeamColor>{ new TeamColor {
                            Color=context.Colors.FirstOrDefault(x=>x.ColorName=="Deneme1")}}
                    },

                    }); ;
                context.SaveChanges();
            }
        }

    }
}
