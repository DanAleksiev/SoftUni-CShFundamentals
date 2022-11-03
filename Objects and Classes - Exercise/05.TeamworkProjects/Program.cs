using System;
using System.Collections.Generic;
using System.Linq;

namespace T05.TeamworkProjects
    {
    class Program
        {
        static void Main(string[] args)
            {
            List<Team> teams = new List<Team>();

            CreateTeams(teams);

            JoinMembers(teams);

            PrintValidTeams(teams);

            PrintDisbandedTeams(teams);
            }
        static void CreateTeams(List<Team> teams)
            {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
                {
                string[] teamArgs = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);

                string currCreator = teamArgs[0];
                string currTeamName = teamArgs[1];

                Team currTeam = new Team(currTeamName, currCreator);

                if (TeamExists(teams, currTeamName))
                    {
                    Console.WriteLine($"Team {currTeam.TeamName} was already created!");
                    }
                else if (CreatorHasTeam(teams, currCreator))
                    {
                    Console.WriteLine($"{currTeam.Creator} cannot create another team!");
                    }
                else
                    {
                    teams.Add(currTeam);

                    Console.WriteLine($"Team {currTeam.TeamName} has been created by {currTeam.Creator}!");
                    }
                }
            }
        static void JoinMembers(List<Team> teams)
            {
            string command;

            while ((command = Console.ReadLine()) != "end of assignment")
                {
                string[] commandArgs = command
                             .Split("->", StringSplitOptions.RemoveEmptyEntries);

                string userToJoin = commandArgs[0];
                string teamToJoin = commandArgs[1];

                if (!TeamExists(teams, teamToJoin))
                    {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                    }
                else if (IsAlreadyAMember(teams, userToJoin) ||
                               IsAlreadyACreator(teams, userToJoin))
                    {
                    Console.WriteLine($"Member {userToJoin} cannot join team {teamToJoin}!");
                    }
                else
                    {
                    //teams.Where(x => x.TeamName == teamToJoin && !x.Members.Contains(userToJoin));
                    //Team teamToAddMember = (Team)teams.Where(x => x.TeamName == teamToJoin);
                    //teamToAddMember.Members.Add(userToJoin);
                    foreach (Team currTeam in teams)
                        {
                        if (currTeam.TeamName == teamToJoin)
                            {
                            currTeam.Members.Add(userToJoin);
                            }
                        }
                    }
                }
            }
        static bool TeamExists(List<Team> teams, string teamName)
            {
            if (teams.Any(x => x.TeamName == teamName))
                {
                return true;
                }
            else
                {
                return false;
                }
            }
        static bool CreatorHasTeam(List<Team> teams, string creator)
            {
            if (teams.Any(x => x.Creator == creator))
                {
                return true;
                }
            else
                {
                return false;
                }
            }
        static bool IsAlreadyAMember(List<Team> teams, string user)
            {
            if (teams.Any(x => x.Members.Contains(user)))
                {
                return true;
                }
            else
                {
                return false;
                }
            }
        static bool IsAlreadyACreator(List<Team> teams, string user)
            {
            if (teams.Any(x => x.Creator == user))
                {
                return true;
                }
            else
                {
                return false;
                }
            }
        static void PrintDisbandedTeams(IList<Team> teams)
            {
            teams = teams.OrderByDescending(x => x.Members.Count).ThenBy(y => y.TeamName).ToList();

            teams = teams.Where(x => x.Members.Count == 0).ToList();

            Console.WriteLine("Teams to disband:");

            if (teams != null)
                {
                foreach (Team currTeam in teams.OrderBy(x => x.TeamName))
                    {
                    Console.WriteLine(string.Join(Environment.NewLine, currTeam.TeamName));
                    }
                }
            }
        static void PrintValidTeams(List<Team> teams)
            {
            teams = teams.OrderByDescending(x => x.Members.Count).ThenBy(y => y.TeamName).ToList();

            teams = teams.Where(x => x.Members.Count > 0).ToList();

            foreach (Team currTeam in teams)
                {
                Console.WriteLine($"{currTeam.TeamName}");
                Console.WriteLine($"- {currTeam.Creator}");

                foreach (string member in currTeam.Members.OrderBy(x => x))
                    {
                    Console.WriteLine($"-- {member}");
                    }
                }
            }
        }
    public class Team
        {
        List<string> members = new List<string>();

        public Team(string teamName, string creator)
            {
            TeamName = teamName;
            Creator = creator;
            }

        public string TeamName { get; private set; }

        public string Creator { get; private set; }

        public List<string> Members
            {
            get => members;

            set => Members = members;
            }
        }
    }