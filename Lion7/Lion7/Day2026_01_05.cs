namespace MyApp;

public class Day2026_01_05 
{
    
    void Task1()
    {
        // 상수
        const int MaxPlayerCount = 4;
        const int StartGold = 100;
        const string Version = "1.0.0";
        
        Console.WriteLine($"==== 게임 설정 ====");
        Console.WriteLine($"MaxPlayerCount : {MaxPlayerCount}");
        Console.WriteLine($"StartGold : {StartGold}");
        Console.WriteLine($"Version : {Version}");
    }

    void Task2()
    {
        //숫자 데이터 형식
        byte level = 50;
        short attack = 1500;
        int gold = 1234567;
        long experience = 99999999L;
        Console.WriteLine($"==== 캐릭터 정보 ====");
        Console.WriteLine($"레벨 : {level}");
        Console.WriteLine($"공격력 : {attack}");
        Console.WriteLine($"소지금 : {gold:N0}");
        Console.WriteLine($"경험치 : {experience:N0}");
        
        Console.WriteLine($"\n==== 타입별 최대값 ====");
        Console.WriteLine($"byte : {byte.MaxValue}");
        Console.WriteLine($"short : {short.MaxValue}");
        Console.WriteLine($"int : {int.MaxValue}");
        Console.WriteLine($"long : {long.MaxValue}");
    }

    void Task3()
    {
        //실수 데이터 형식
        float singlePrecision = 3.14f;
        double doublePrecision = 3.1415926435d;
        decimal highPrecision = 3.1415926435897932384626433833m;
        
        Console.WriteLine(singlePrecision);
        Console.WriteLine(doublePrecision);
        Console.WriteLine(highPrecision);
        
        // 접미사
        int integer = 100;
        long longValue = 100L;
        float floatValue = 3.14f;
        double doubleValue = 3.14d;
        decimal decimalValue = 3.14m;

        Console.WriteLine(integer);
        Console.WriteLine(longValue);
        Console.WriteLine(floatValue);
        Console.WriteLine(doubleValue);
        Console.WriteLine(decimalValue);
    }

    void Task4()
    {
        // 단일문자표현
        char grade = 'A';
        char symbol = '★';
        char number = '9';
        string playerName = "이수현";
        string welcomeMessgage = "게임에 오신 것을 환영합니다!";
        string emptyString = string.Empty;
        Console.WriteLine($"=== RPG 게임 ===");
        Console.WriteLine($"플레이어 : {playerName}");
        Console.WriteLine($"등급 : {grade}등급 {symbol}");
        Console.WriteLine($"{welcomeMessgage}");
    }

    void Task5()
    {
        char character = (char)65;
        char grade = 'A';
        char symbol = '★';
        char number = '9';
        string playerName = "이수현";
        string welcomeMessgage = "게임에 오신 것을 환영합니다!";
        string emptyString = string.Empty;
        Console.WriteLine($"=== RPG 게임 ===");
        Console.WriteLine($"플레이어 : {character}");
        Console.WriteLine($"등급 : {grade}등급 {symbol}");
        Console.WriteLine($"{welcomeMessgage}");
    }

    void Task6()
    {
        bool isRunning = true;
        bool isStop = false;
        bool key = false;
        bool openDoor = false;
        bool playerAlive = true;

        int hp = 80;
        bool ishealth = true;
        bool isDanger = true;
        
        Console.WriteLine("== 게임 상테 ===");
        Console.WriteLine($"게임 실행 중 : {isRunning}");
        Console.WriteLine($"일시 정지 : {isStop}");
        Console.WriteLine($"열쇠 소지 : {key}");
        Console.WriteLine($"문 열림 : {openDoor}");
        Console.WriteLine($"플레이어 생존 : {playerAlive}");
        
                 
        Console.WriteLine("== 캐릭터 상태 ===");
        Console.WriteLine($"체력 : {hp}");
        Console.WriteLine($"건강 상태 : {ishealth}");
        Console.WriteLine($"위험 상태 : {isDanger}");
    }
}