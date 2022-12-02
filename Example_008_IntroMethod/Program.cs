int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1=5;
int a2=4;
int a3=9;
int a4=10000;
int a5=15;
int a6=20;
int a7=251;
int a8=300;
int a9=10001;

int max= Max((Max(a1,a2,a3)),Max(a4,a5,a6),Max(a7,a8,a9));
Console.WriteLine(max);
