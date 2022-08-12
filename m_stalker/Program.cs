using static System.Console;

Random rnd = new Random();
bool isGoInZone = false;
bool isGoInMagazine = false;
bool isOpenInventory = false;
bool isQuitGame = false;
int countAKs74y = 0;
int countAK47 = 0;
int countM4A4 = 0;
int countP28 = 0;
int countGlock18 = 0;
int countKnife = 0;
int countGasmask = 0;
int countBackpack = 0;
int countMeal = 0;
int countWater = 0;
int countBigBackpack = 0;
int countLargeBackpack = 0;
int countBandage = 0;
string isGoOutZone = "";
string isCloseInventory = "";
int Money = 0;
double maxHeight = 12;
double actuallyHeight = 0;
int speedHungry = 3;
int maxHungry = 100;
int actuallyHungry = maxHungry;
int countHungry = 6;
int speedThirst = 3;
int maxThirst = 100;
int actuallyThirst = maxThirst;
int countThirst = 8;
int maxHP = 100;
int actuallyHP = maxHP;
int minHP = 0;
int maxRad = 100;
int minRad = 0;
int actuallyRad = minRad;
bool bonusStart = true;
int bandageHeal = 40;
List<string> backpack = new List<string>();
List<double> heightItems = new List<double>();
heightItems.Add(2.5);
heightItems.Add(3);
heightItems.Add(2.9);
heightItems.Add(0.7);
heightItems.Add(0.8);
heightItems.Add(0.6);
heightItems.Add(0.4);
heightItems.Add(0.2);
heightItems.Add(0.6);
heightItems.Add(1);
heightItems.Add(0.5);
heightItems.Add(1.2);
heightItems.Add(0.1);

List<int> itemCost = new List<int>();
itemCost.Add(2500);
itemCost.Add(3500);
itemCost.Add(4000);
itemCost.Add(2000);
itemCost.Add(1900);
itemCost.Add(1450);
itemCost.Add(1230);
itemCost.Add(1200);
itemCost.Add(800);
itemCost.Add(750);
itemCost.Add(1800);
itemCost.Add(3200);
itemCost.Add(420);

List<string> textForZone = new List<string>();
textForZone.Add("Я пока шёл, снова порвал куртку, придётся опять зашивать");
textForZone.Add("Вдалеке услышал большое количество шагов, пойду в обход");
textForZone.Add("Пока шёл, упал в радиоктивное пятно и получил Rad:");
textForZone.Add("Я нашёл:");

List<string> items = new List<string>();
items.Add("АКс-74y");
items.Add("АК-47");
items.Add("M4A4");
items.Add("P28");
items.Add("Glock 18");
items.Add("Нож");
items.Add("Противогаз");
items.Add("Рюкзак");
items.Add("Тушёнка");
items.Add("Водичка");
items.Add("Большой рюкзак");
items.Add("Огромный рюкзак");
items.Add("Бинт");


while (!isQuitGame)
{
    if(bonusStart)
    {
        backpack.Add("Водичка");
        backpack.Add("Тушёнка");
        countWater += 1;
        countMeal += 1;
        //bonus
    }
    bonusStart = false;

    WriteLine("[1]Войти в зону\n[2]Магазин\n[3]Инвентарь\n[4]Выйти из игры");

    string chooseNumber = ReadLine();
    switch (chooseNumber)
    {
        case "1":
            isGoInZone = true;
            break;

        case "2":
            isGoInMagazine = true;
            break;

        case "3":
            isOpenInventory = true;
            break;


        case "4":
            isQuitGame = true;
            break;

        default:
            WriteLine("ERROR ERROR ERROR ERROR ERROR ERROR\nКОД ОСТАНОВКИ 404\nВЫХОД ИЗ ИГРЫ");
            isQuitGame = true;
            break;
    }

    if (isGoInZone)
    {
        whatAndHowManyItemsInBackpack();
        Zone();
    }

    if (isGoInMagazine)
    {
        whatAndHowManyItemsInBackpack();
        Magazine();
    }

    if (isOpenInventory)
    {
        WriteLine("Вы открыли инвентарь");
        Inventory();
    }

    if (isQuitGame)
    {
        WriteLine("Выход из игры");
        break;
    }
}

void Zone()
{
    int k = 0;
    int valueText;
    int valueItems;
    int countRad;

    while (isGoOutZone != "I go out")
    {
        valueText = rnd.Next(4);
        valueItems = rnd.Next(13);
        countRad = rnd.Next(4);
        if (k == speedHungry || k == speedThirst)
        {
            actuallyHungry -= countHungry;
            WriteLine($"Ваш голод:{actuallyHungry}");
            actuallyThirst -= countThirst;
            WriteLine($"Ваша жажда:{actuallyThirst}");
            k = 0;
        }

        WriteLine(textForZone[valueText]);

        if (valueText == 2)

            WriteLine(" " + countRad + " ");
        if (valueText == 3)
        {
            WriteLine(" " + items[valueItems] + " ");

            backpack.Add(items[valueItems]);


            switch (valueItems)
            {
                case 0:
                    countAKs74y++;
                    actuallyHeight += heightItems[valueItems];
                    break;

                case 1:
                    countAK47++;
                    actuallyHeight += heightItems[valueItems];
                    break;

                case 2:
                    countM4A4++;
                    actuallyHeight += heightItems[valueItems];
                    break;

                case 3:
                    countP28++;
                    actuallyHeight += heightItems[valueItems];
                    break;

                case 4:
                    countGlock18++;
                    actuallyHeight += heightItems[valueItems];
                    break;

                case 5:
                    countKnife++;
                    actuallyHeight += heightItems[valueItems];
                    break;

                case 6:
                    countGasmask++;
                    actuallyHeight += heightItems[valueItems];
                    break;

                case 7:
                    countBackpack++;
                    actuallyHeight += heightItems[valueItems];
                    break;

                case 8:
                    countMeal++;
                    actuallyHeight += heightItems[valueItems];
                    break;

                case 9:
                    countWater++;
                    actuallyHeight += heightItems[valueItems];
                    break;

                case 10:
                    countBigBackpack++;
                    actuallyHeight += heightItems[valueItems];
                    break;

                case 11:
                    countLargeBackpack++;
                    actuallyHeight += heightItems[valueItems];
                    break;

                case 12:
                    countBandage++;
                    actuallyHeight += heightItems[valueItems];
                    break;
            }
        }
        k++;

        if (actuallyHeight >= maxHeight)
        {
            WriteLine("Вы достигли максимального веса");
            break;
        }

        if (actuallyHungry <= 10)
        {
            WriteLine("У вас сильный голод");
            break;
        }

        if (actuallyThirst <= 10)
        {
            WriteLine("У вас сильная жажда");
            break;
        }

        if(actuallyHP <= 10)
        {
            WriteLine("У вас мало ОЗ");
            break;
        }

        if (actuallyHP <= minHP)
        {
            Die();
            break;
        }
        isGoOutZone = ReadLine();
    }
    WriteLine("Вы вышли из зоны");
    isGoInZone = false;
}

void Magazine()
{
    WriteLine("Хотите-ли вы продать всё содержимое рюкзака");

    string chooseInMagazine = ReadLine();

    if (chooseInMagazine == "y" || chooseInMagazine == "yes")
    {
        int valueMoney = itemCost[0] * countAKs74y;
        valueMoney += itemCost[1] * countAK47;
        valueMoney += itemCost[2] * countM4A4;
        valueMoney += itemCost[3] * countP28;
        valueMoney += itemCost[4] * countGlock18;
        valueMoney += itemCost[5] * countKnife;
        valueMoney += itemCost[6] * countGasmask;
        valueMoney += itemCost[7] * countBackpack;
        valueMoney += itemCost[10] * countBigBackpack;
        valueMoney += itemCost[11] * countLargeBackpack;
        countAKs74y = 0;
        countAK47 = 0;
        countM4A4 = 0;
        countP28 = 0;
        countGlock18 = 0;
        countKnife = 0;
        countGasmask = 0;
        countBackpack = 0;
        countBigBackpack = 0;
        countLargeBackpack = 0;

        Money += valueMoney;
    }
    else if(chooseInMagazine == "n" || chooseInMagazine == "no")
    {
        WriteLine("Выход из Магазина");
    }

    actuallyHeight = 0;
    isGoInMagazine = false;
    WriteLine($"У вас {Money} монет");
}

void Inventory()
{
    int w;
    int m;
    while (isCloseInventory != "I close inventory" || isOpenInventory)
    {
        WriteLine($"У вас есть\n[1]Рюкзак x {countBackpack}\n[2]Большой рюкзак x {countBigBackpack}\n[3]Огромный рюкзак x {countLargeBackpack}\n[4]Тушёнка x {countMeal}\n[5]Водичка x {countWater}\n[6]Бинт");

        int value = int.Parse(ReadLine());

        switch (value)
        {
            case 1:
                if (countBackpack >= 1)
                {
                    countBackpack--;
                    maxHeight = 18;
                    WriteLine("Вы надели рюкзак");
                    isOpenInventory = false;
                }
                break;

            case 2:
                if (countBigBackpack >= 1)
                {
                    countBigBackpack--;
                    maxHeight *= 24;
                    WriteLine("Вы надели большой рюкзак");
                    isOpenInventory = false;
                }
                break;

            case 3:
                if (countLargeBackpack >= 1)
                {
                    countLargeBackpack--;
                    maxHeight *= 32;
                    WriteLine("Вы надели огромный рюкзак");
                    isOpenInventory = false;
                }
                break;

            case 4:
                if(countMeal >= 1 && maxHungry - actuallyHungry <= 80)
                {
                    countMeal--;
                    m = maxHungry - actuallyHungry;
                    actuallyHungry += m;
                    WriteLine("Вы утолили голод");
                    isOpenInventory = false;
                }
                break;

            case 5:
                if (countWater >= 1 && maxThirst - actuallyThirst <= 80)
                {
                    countWater--;
                    w = maxThirst - actuallyThirst;
                    actuallyThirst += w;
                    WriteLine("Вы утолили жажду");
                    isOpenInventory = false;
                }
                break;

            case 6:
                if(countBandage  >= 1 && actuallyHP <= 10)
                {
                    countBandage--;
                    actuallyHP += bandageHeal;
                    if(actuallyHP > maxHP)
                        actuallyHP = maxHP;
                }
                break;

            default:
                WriteLine("У вас нету данного рюкзака или неверное число, неверное слово или буква");
                break;
        }
        if (isOpenInventory)
            isCloseInventory = ReadLine();
        else
            break;
    }
    isOpenInventory = false;
}

void whatAndHowManyItemsInBackpack()
{
    WriteLine($"У вас в рюкзаке:\nАКс-74у x {countAKs74y}\nАК-47 x {countAK47}\nМ4А4 x {countM4A4}\nP28 x {countP28}\nGlock 18 x {countGlock18}\nНож x {countKnife}\nПротивогаз x {countGasmask}\nРюкзак x {countBackpack}\nТушёнка х {countMeal}\nВодички x {countWater} литров\nБольшой рюкзак x {countBigBackpack}\nОгромный рюкзак x {countLargeBackpack}\nБинт x {countBandage}");
}

void Die()
{
    bonusStart = true;
    countAK47 = 0;
    countAKs74y = 0;
    countBackpack = 0;
    countBandage = 0;
    countBigBackpack = 0;
    countGasmask = 0;
    countGlock18 = 0;
    countKnife = 0;
    countLargeBackpack = 0;
    countM4A4 = 0;
    countMeal = 0;
    countP28 = 0;
    countWater = 0;
    backpack.Clear();
    actuallyHeight = 0;
    actuallyHP = maxHP;
    actuallyHungry = maxHungry;
    actuallyThirst = maxThirst;
}