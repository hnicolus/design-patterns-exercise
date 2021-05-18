using System;

namespace Patterns.Composite.Exercise
{
    public static class FireFighterProgram
    {
        public static void Run()
        {
            var subTeam1 = new Team();
            subTeam1.Add(new Truck());
            subTeam1.Add(new HumanResource());
            subTeam1.Add(new HumanResource());

            var subTeam2 = new Team();
            subTeam2.Add(new Truck());
            subTeam2.Add(new HumanResource());
            subTeam2.Add(new HumanResource());

            var team = new Team();
            team.Add(subTeam1);
            team.Add(subTeam2);

            team.Deploy();
        }
    }
}