int t1 = 1;
int t2 = 0;
int t3 = 0;

while (t3 < 1000000)
{
t3=t1+t2;   
Console.Write(t3 + " ");
t1=t2;
t2=t3;
}