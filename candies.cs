int candies(int n, int m) {
  int a=0,i=0;
while(a<m)
{
    a=n*i;
    i++;
}
return a;
}