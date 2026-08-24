using EncapsulationTest.Functions;
using EncapsulationTest.Operations;
using EncapsulationTestStudent;

//Student _student = new Student("Milfred", "Kilaton", DateTime.Parse("May 2, 2006"));
// Console.WriteLine(_student.DisplayStudent());

// Student _student2 = new Student("Milfred", "Kilaton", DateTime.Parse("03/22/2006"));
// Console.WriteLine(_student2.DisplayStudent());

bool _continue = true;
while (_continue)
{
    Console.Clear();
    Console.WriteLine(OperationsMenu.ShowMainMenu());
    int choice = OperationsMenu.SelectOperation();

    switch (choice)
    {
        case 1:
            Addition addition = new Addition();
            addition.InputNumbersForAddition();
            Console.WriteLine(addition.ShowSum());
            Console.ReadKey();
            break;
        case 2:
            Substraction substraction = new Substraction();
            substraction.InputNumbersForSubstraction();
            Console.WriteLine(substraction.ShowDifference());
            Console.ReadKey();
            break;
        case 3:
            Multiplication multiplication = new Multiplication();
            multiplication.InputNumbersForMultiplication();
            Console.WriteLine(multiplication.ShowProduct());
            Console.ReadKey();
            break;
        case 4:
            Division division = new Division();
            division.InputNumbersForDivision();
            Console.WriteLine(division.ShowQuotient());
            Console.ReadKey();
            break;
        case 5:
            _continue = false;
            break;
        default:
            Console.WriteLine("Invalid Input");
            break;
    }
}
