using System;
using System.Diagnostics.Metrics;

int length = 10;
int health = 100;
int respect = 20;
double weight = 30.0;
int day_or_night = 1;
Random rand = new Random();
void print()
{
    Console.WriteLine();
    Console.WriteLine($"����� ����� ����: {length}");
    Console.WriteLine($"��� ��������: {health}");
    Console.WriteLine($"��� ��������: {respect}");
    Console.WriteLine($"���� ���: {weight}");
    Console.WriteLine();
}

Console.WriteLine("����� ����������! ���������, ��� ������� ����� �� ��������� � ���� ���������. ��� ���� ��������������:");
print();
Console.WriteLine("�� ��� �� ���� ����� ���������, ��� ��� �������� ���� ������� �������� (100). �� ��� ������ ������ �����������!");
Console.WriteLine();

while ((length > 0) & (health > 0) & (respect < 100) & (weight > 0))
{
    while (day_or_night == 1)
    {
        Console.WriteLine("�������� ����. ���������, ���� �������������� �� ������ ������:");
        print();
        Console.WriteLine("��� �� �� ��������� �������? ������ �����.");
        Console.WriteLine();
        Console.WriteLine("1: ������ ����");
        Console.WriteLine("2: ������ ������");
        Console.WriteLine("3: ����� �������");
        Console.WriteLine("4: ������� ���� ����");
        Console.WriteLine();
        int change = Convert.ToInt32(Console.ReadLine());
        switch (change)
        {
            case 1:
                Console.WriteLine();
                Console.WriteLine("��� �� ������ ������?");
                Console.WriteLine("1: ����������");
                Console.WriteLine("2. ������");
                Console.WriteLine();
                int change_kopat = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (change_kopat)
                {
                    case 1:
                        Console.WriteLine("� �� �����! ���� �������������� ��������� ��������� ���������:");
                        length += 5;
                        health -= 30;
                        print();
                        break;
                    case 2:
                        Console.WriteLine("�� �����, ��� �� ������! ���� �������������� ���� ����������:");
                        length += 2;
                        health -= 10;
                        print();
                        break;
                }
                break;
            case 2:
                Console.WriteLine("�������, ����� ������ �� ������ ������:");
                Console.WriteLine();
                Console.WriteLine("1: ������");
                Console.WriteLine("2: �������");
                Console.WriteLine();
                int change_grass = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (change_grass)
                {
                    case 1:
                        Console.WriteLine("�����, �������, ������. �� ��� ��������... ���� ��������������:");
                        health += 10;
                        weight += 15;
                        print();
                        break;
                    case 2:
                        if (respect < 30)
                        {
                            Console.WriteLine("���... ����� �� ������� �� �������, ���� �� ��� ������. ���� ��������������:");
                            health -= 30;
                            print();
                        }
                        if (respect >= 30)
                        {
                            Console.WriteLine("������ ������� �������! ���� ��������������:");
                            health += 30;
                            weight += 30;
                            print();
                        }
                        break;
                }
                break;
            case 3:
                Console.WriteLine("� ��� ������ ���������?");
                Console.WriteLine();
                Console.WriteLine("1: � �����");
                Console.WriteLine("2: �� ����������");
                Console.WriteLine("3: � ������ ��������� �� ������");
                Console.WriteLine();
                int change_enemy = Convert.ToInt32(Console.ReadLine());
                switch (change_enemy)
                {
                    case 1:
                        double randomchic = rand.NextDouble();
                        if (randomchic >= weight / (30 + weight))
                        {
                            if (weight > 30)
                            {
                                Console.WriteLine("������ ���� �� �����, �� �� �������, ���� ���������� ����������...");
                                health -= 15;
                                respect += 5;
                                print();
                            }
                            if (weight == 30)
                            {
                                Console.WriteLine("�������))) ���� ���������� ����������!");
                                health -= 35;
                                respect += 20;
                                print();
                            }
                            if (weight < 30)
                            {
                                Console.WriteLine("�� �� ����!!! ���� ���������� ����������!");
                                health -= 70;
                                respect += 40;
                                print();
                            }
                        }
                        if (randomchic < weight / (30 + weight))
                        {
                            if (weight > 30)
                            {
                                Console.WriteLine("�� �� � ���... ��������� ������ �����...");
                                health -= 15;
                                respect -= 15;
                                print();
                            }
                            if (weight == 30)
                            {
                                Console.WriteLine("�� �������... �� �� �� ������������� �;");
                                health -= 35;
                                print();
                            }
                            if (weight < 30)
                            {
                                Console.WriteLine("������� - �� �����! ����, �������, �� � ����� ������... �� ���� ���� �� �����");
                                health -= 70;
                                respect += 10;
                            }
                        }
                        break;
                    case 2:
                        double randomchic1 = rand.NextDouble();
                        if (randomchic1 >= weight / (30 + weight))
                        {
                            if (weight > 50)
                            {
                                Console.WriteLine("�������, ���� ���������� ����������! �� �� ���� �� ��������� � ���-�� ����� �������?");
                                health -= 15;
                                respect += 5;
                                print();
                            }
                            if (weight == 50)
                            {
                                Console.WriteLine("�������))) ���� ���������� ����������!");
                                health -= 35;
                                respect += 20;
                                print();
                            }
                            if (weight < 50)
                            {
                                Console.WriteLine("����� ������� �� ���� � ������� �������� �� ������!!! ���� ���������� ����������!");
                                health -= 70;
                                respect += 40;
                                print();
                            }
                        }
                        if (randomchic1 < weight / (50 + weight))
                        {
                            if (weight > 50)
                            {
                                Console.WriteLine("�� ��� ������� ��������� ����������, ������� ��� �������. � �������� ��� � ���� ����� ���������!");
                                health -= 15;
                                respect -= 15;
                                print();
                            }
                            if (weight == 50)
                            {
                                Console.WriteLine("�� �������... �� �� �� ������������� �;");
                                health -= 35;
                                print();
                            }
                            if (weight < 50)
                            {
                                Console.WriteLine("������� - �� �����! ����, �������, �� � ����� ������... �� ���� ���� �� �����");
                                health -= 70;
                                respect += 10;
                            }
                        }
                        break;
                    case 3:
                        double randomchic2 = rand.NextDouble();
                        if (randomchic2 >= weight / (70 + weight))
                        {
                            if (weight > 70)
                            {
                                Console.WriteLine("������ ���� �� ����! �� �� ��������� �����������))");
                                health -= 15;
                                respect += 25;
                                print();
                            }
                            if (weight == 70)
                            {
                                Console.WriteLine("�������))) �� ������� ���������� ������� ����! ���� ���������� ����������!");
                                health -= 35;
                                respect += 35;
                                print();
                            }
                            if (weight < 70)
                            {
                                Console.WriteLine("��� �� �� ������, � �� �������!!!");
                                health -= 70;
                                respect += 50;
                                print();
                            }
                        }
                        if (randomchic2 < weight / (70 + weight))
                        {
                            if (weight > 70)
                            {
                                Console.WriteLine("�� ��� ������� ��������� ����������, ������� ��� �������. � �������� ��� � ���� ����� ���������!");
                                health -= 15;
                                respect -= 15;
                                print();
                            }
                            if (weight == 70)
                            {
                                Console.WriteLine("�� �������... �� �� �� ������������� �;");
                                health -= 35;
                                print();
                            }
                            if (weight < 70)
                            {
                                Console.WriteLine("������� - �� �����! ����, �������, �� � ����� ������... �� ���� ���� �� �����");
                                health -= 70;
                                respect += 10;
                            }
                        }
                        break;
                }
                break;
            case 4:
                Console.WriteLine("�������� ������� ���...");
                Console.WriteLine();
                length -= 2;
                health += 10;
                respect -= 2;
                weight -= 5;
                print();
                break;
        }
        day_or_night -= 1;
    }
    while (day_or_night == 0)
    {
        Console.WriteLine("����� ���� ���������� ��� ������...");
        Console.WriteLine();
        Console.WriteLine("���� �������������� ���� ����������!");
        length -= 2;
        health += 10;
        respect -= 2;
        weight -= 5;
        print();
        day_or_night += 1;
    }
}

if ((length <= 0) | (health <= 0) | (weight <= 0))
{
    Console.WriteLine("All my friends are toxic... �� �������� :�");
}
if (respect >= 100)
{
    Console.WriteLine("���, ������!!! ����������!!! ����� ��������� ������� �� ������)))");
}