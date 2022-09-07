using System;

public class Program {
    
    static void PrintInputInformation(string name,
    string number,
    string OwnerName,
    string RegisteredValue) {
        Console.WriteLine("—--------- Shop Information —-----");
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Number: {0}", number);
        Console.WriteLine("Owner Name: {0}", OwnerName);
        Console.WriteLine("Registered Value: {0}", RegisteredValue);
        Console.WriteLine("—-----------------------------------------------------");
    }

    public static void Main(string[] args) {
        
        InputInfo info = new InputInfo();
        Console.Write("Please Input Name: ");
        info.InputName = Console.ReadLine();
        string name = info.InputName;
        Console.Write("Please Input Number: ");
        info.InputNumber = Console.ReadLine();
        string number = info.InputNumber;
        Console.Write("Please Input owner name: ");
        info.ownerName = Console.ReadLine();
        string OwnerName = info.ownerName;
        Console.Write("Please Input registered value: ");
        info.registeredValue = Console.ReadLine();
        string RegisteredValue = info.registeredValue;
        Coin M = new Coin();


        PrintInputInformation(name, number, OwnerName, RegisteredValue);
        Console.Write("Please input money: ");
        double money = double.Parse(Console.ReadLine());
        M.InputMoney(money);
    }
    
}

public class InputInfo {
    public string InputName;
    public string InputNumber;
    public string ownerName;
    public string registeredValue;
}

public class Coin {
    public void InputMoney(double money) {
        
        double baht=0;
        int A = 0;
        while(baht<=money){
            if(money>=1000) {
                baht += 1000;
                if(baht<=money){
                    A++;
                }
            } 
        } Console.WriteLine("1000: {0}", A);
        
        int B = 0;
        money = money-A*1000;
        baht = 0;
        while(baht<=money){
            baht += 500;
            if(money>=500) {
                if(baht<=money){
                    B++;
                }
            } 
        }   Console.WriteLine("500: {0}", B);

        int C = 0;
        money = money-B*500;
        baht = 0;
        while(baht<=money){
            baht += 100;
            if(money>=100) {
                if(baht<=money){
                    C++;
                }
            } 
        }   Console.WriteLine("100: {0}", C);
        
        int D = 0;
        money = money-C*100;
        baht = 0;
        while(baht<=money){
            baht += 50;
            if(money>=50) {
                if(baht<=money){
                    D++;
                }
            } 
        }   Console.WriteLine("50: {0}", D);

        int E = 0;
        money = money-D*50;
        baht = 0;
        while(baht<=money){
            baht += 10;
            if(money>=10) {
                if(baht<=money){
                    E++;
                }
            } 
        }   Console.WriteLine("10: {0}", E);

        int F = 0;
        money = money-E*10;
        baht = 0;
        while(baht<=money){
            baht += 5;
            if(money>=5) {
                if(baht<=money){
                    F++;
                }
            } 
        }   Console.WriteLine("5: {0}", F);

        int G = 0;
        money = money-F*5;
        baht = 0;
        while(baht<=money){
            baht += 2;
            if(money>=2) {
                if(baht<=money){
                    G++;
                }
            } 
        }   Console.WriteLine("2: {0}", G);

        int H = 0;
        money = money-F*2;
        baht = 0;
        while(baht<=money){
            baht += 1;
            if(money>=1) {
                if(baht<=money){
                    H++;
                }
            } 
        }   Console.WriteLine("1: {0}", H);

        int I = 0;
        money = money-H;
        baht = 0;
        while(baht<=money){
            baht += 0.5;
            if(money>=0.5) {
                if(baht<=money){
                    I++;
                }
            } 
        }   Console.WriteLine("0.50: {0}", I);

        int J = 0;
        money = money-I*0.5;
        baht = 0;
        while(baht<=money){
            baht += 0.25;
            if(money>=0.25) {
                if(baht<=money){
                    J++;
                }
            } 
        }   Console.WriteLine("0.25: {0}", J);
    }
}