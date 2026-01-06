namespace MyApp;

public class Day2026_01_06
{
    void Task1()
    {
        Console.Write("이름을 입력하세요 : ");
        string name = Console.ReadLine() ?? string.Empty;
        Console.WriteLine($"안녕하세요 {name}님");
    }

    void Task2()
    {
        Console.Write("나이를 입력하세요 : ");
        string age = Console.ReadLine() ?? string.Empty;
        Console.WriteLine($"내년에는 {int.Parse(age) + 1}살이 되겠군요!");
    }

    void Task3()
    {
        Console.Write("2진수를 입력하세요 : ");
        string binaryInput = Console.ReadLine() ?? string.Empty;
        int decimalNumber = Convert.ToInt32(binaryInput,2);
        Console.WriteLine($"{decimalNumber}");
            
        Console.WriteLine($"{Convert.ToString(decimalNumber)}");
    }

    void Task4()
    {
        Console.Write("캐릭터 이름을 입력하세요 : ");
        string name = Console.ReadLine();
        Console.WriteLine($"환영합니다, {name}님!");

        Console.Write("시작레벨을 입력하세요 : ");
        int level = int.Parse(Console.ReadLine());
        Console.WriteLine($"{name}님의 시작 레벨은 {level}입니다");
    }

    void Task5()
    {
        var name = "Garen";
        var age = -999;
        var isDemasia = true;
        Console.WriteLine($"이름 : {name}, 나이 : {age}, 여부 : {isDemasia}");
    }

    void Task6()
    {
        // input 5 8 4
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = inputs[0]; // 5
            int b = inputs[1]; // 8
            int c = inputs[2]; // 4

            
            int maxHP = 100;
            int currentHP = 80;
            Console.WriteLine($"초기 체력 : {currentHP}/{maxHP}");
            currentHP -= 25;
            Console.WriteLine($"데미지 -25 : {currentHP}/{maxHP}");
            currentHP += 30;
            Console.WriteLine($"회복 : {currentHP}/{maxHP}");
            currentHP += 5;
            Console.WriteLine($"독 데미지 : {currentHP}/{maxHP}\n");
            
            int expPerMonster = 150;
            int monstersKilled = 3;
            int expForLevelUp = 500;
            Console.WriteLine($"처치한 몬스터 : {monstersKilled}마리");
            Console.WriteLine($"획득 경험치 : {expPerMonster * monstersKilled}");
            Console.WriteLine($"레벨업 까지 필요 : {expForLevelUp - expPerMonster* monstersKilled}\n");

            int totalGold = 1234;
            int partyMembers = 5;
            Console.WriteLine($"총 골드 : {totalGold}");
            Console.WriteLine($"파티원 : {partyMembers}");
            Console.WriteLine($"1인당 골드 : {totalGold / partyMembers}");
            Console.WriteLine($"남은 골드 : {totalGold % partyMembers}\n");
            
            int playerLevel = 35;
            int requiredLevel = 30;
            bool hasKey = true;
            currentHP = 60;
            maxHP = 100;
            Console.WriteLine($"=== 던전 입장 조건 ===");
            var levelKey = requiredLevel <= playerLevel;
            Console.WriteLine($"레벨 조건 (30 이상) : {levelKey}");
            Console.WriteLine($"열쇠 보유 : {hasKey}");
            var hpKey = 50 <= (maxHP / currentHP * 100);
            Console.WriteLine($"체력 조건 (50% 이상) : {hpKey}");
            Console.WriteLine($"입장 가능 : {levelKey && hpKey && hasKey}\n");

            float originalPrice = 5000;
            Console.WriteLine($"원가 : {originalPrice} 골드");
            originalPrice *= 0.2f;
            Console.WriteLine($"VIP 할인 (20%) : {originalPrice} 골드");
            originalPrice -= 500;
            Console.WriteLine($"쿠폰 할인 (-500) : {originalPrice} 골드");
            Console.WriteLine($"최종 가격 : {originalPrice} 골드");
    }
}