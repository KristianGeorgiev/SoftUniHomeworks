using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentAndWorker
{
    class HumanStudentAndWorker
    {
        static void Main(string[] args)
        {
            Student studentOne = new Student("Kalina", "Grigorova", "123456");
            Student studentTwo = new Student("Galin", "manolov", "004568");
            Student studentThree = new Student("Vladislav", "Angelov", "245986");
            Student studentFour = new Student("Velin", "Lechev", "548962");
            Student studentFive = new Student("Proslav", "Gaidarov", "024895");
            Student studentSix = new Student("Spas", "Petrov", "438715");
            Student studentSeven = new Student("Krasen", "Vidinski", "654826");
            Student studentEight = new Student("Lidia", "Baycheva", "468168");
            Student studentNine = new Student("Vasilena", "Prostakova", "185468");
            Student studentTen = new Student("Kalia", "Porqzova", "647965");

            Worker workerOne = new Worker("Petar", "Moskov", 250.65M, 8.0D);
            Worker workerTwo = new Worker("Spas", "Delev", 2450.55M, 8.0D);
            Worker workerThree = new Worker("Kalin", "MIlanov", 270.48M, 10.0D);
            Worker workerFour = new Worker("Marin", "Kralev", 150.65M, 5.0D);
            Worker workerFive = new Worker("Veselin", "Pavlov", 295.65M, 8.0D);
            Worker workerSix = new Worker("Petar", "Klokochev", 178.65M, 8.0D);
            Worker workerSeven = new Worker("Stoqn", "Karparov", 250.65M, 8.0D);
            Worker workerEight = new Worker("Kaloqn", "Petrovich", 230.65M, 8.0D);
            Worker workerNine = new Worker("Yordan", "Garov", 250.65M, 8.0D);
            Worker workerTen = new Worker("Vladislav", "Karamfilov", 250.65M, 8.0D);


        }
    }
}
