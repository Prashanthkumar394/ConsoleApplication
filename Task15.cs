using System;

namespace Task15
{
    interface ICreateTask
    {
        void CreateTask();
    }
    interface IAssignTask
    {
        void AssignTask();
    }
    interface IPerformTask
    {
        void PerformTask();
    }
    class Manager : ICreateTask, IAssignTask
    {
        public void CreateTask()
        {
            Console.WriteLine("Manager created task");
        }
        public void AssignTask()
        {
            Console.WriteLine("Manager assigned task");
        }
    }
    class TeamLead : ICreateTask, IAssignTask, IPerformTask
    {
        public void CreateTask()
        {
            Console.WriteLine("Team lead created task");
        }
        public void AssignTask()
        {
            Console.WriteLine("Team lead assigned task");
        }
        public void PerformTask()
        {
            Console.WriteLine("Team lead perfomed task");
        }
    }
    class Programmer : IPerformTask
    {
        public void PerformTask()
        {
            Console.WriteLine("Programmer performed task");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.CreateTask();
            manager.AssignTask();

            Console.WriteLine();

            TeamLead TL = new TeamLead();
            TL.CreateTask();
            TL.AssignTask();
            TL.PerformTask();

            Console.WriteLine();

            Programmer programmer = new Programmer();
            programmer.PerformTask();
        }
    }
}