// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//["Hello", "2", "world", ":-)"] → ["2", ":-)"]
//["1234", "1567", "-2", "computer science"] → ["-2"]
//["Russia", "Denmark", "Kazan"] → []

    string[] FirstArray = {"Hello", "2", "world", ":-)"};
    string[] SecondArray = new string [FirstArray.Length];
    int n = 3;
    int i = 0;
    int j = 0;
    
    for (i = 0; i <FirstArray.Length; i++)
    {
        if (FirstArray[i].Length <=n)
        {
            SecondArray[j] = FirstArray[i];
            Console.WriteLine (SecondArray[j]);            
            j++; 
        }
    }
