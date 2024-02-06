
//HOME TASKS



//1.Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.

//int n = 21;
//if (n%3 == 0 && n%7==0) 
//{
//    Console.WriteLine("Bolunur");
//}
//else
//{
//    Console.WriteLine("bolunmur");
//}


//2.n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.
//int n = 20;
//int m = 30;
//int sum = 0;
//if (n%2==0&&m%2==0)
//{
//    sum = n + m;
//    Console.WriteLine(sum);
//}


//3.Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.
//int n = 23;
//int m = 30;
//int sum = 0;
//if (n < m)
//{
//    for (int i = n+1; i < m; i++) 
//    { 
//        if (i%2 == 1) 
//        {
//         sum += i;
//        } 
//    }
//    Console.WriteLine(sum);
//}

//4.Verilmish arrayin icindeki tek ededlerin cemini tapin.
//int [] arr = {1, 2, 3,224,32,212,3234,2,3,7};
//int sum = 0;
//for (int i = 0; i < arr.Length; i++) 
//{
//    if (arr[i]%2!= 0)
//    { 
//    sum+=arr[i] ;
//    }
//}    
//Console.WriteLine(sum);



//5.Verilmish arrayin icindeki cut ededlerin sayini tapin.
//int[] arr = { 1, 2, 3, 224, 32, 212, 3234, 2, 3, 7,8,10};
//int count = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);




//6.Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.

//int n = 23;
//int m = 32;
//int count = 0;
//if (n < m)
//{
//    for (int i = n + 1; i < m; i++)
//    {
//        if (i % 2 == 1)
//        {
//            count++;
//        }

//    }
//    Console.WriteLine(count);
//}


//7.Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin cemini tapin.
//using System.Diagnostics.Metrics;

//int n = 23;
//int m = 30;
//int sum = 0;
//if (n < m)
//{
//    for (int i =n+1; i < m; i++) 
//    { 
//        if (i%2 == 0) 
//        {  
//            sum+= i; 
//        }

//    }
//    Console.WriteLine(sum);
//}


//8.Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin sayini tapin.
//int n = 1;
//int m = 10;
//int count = 0;
//if (n < m)
//{
//    for (int i = n + 1; i < m; i++)
//    {
//        if (i % 2 == 0)
//        {
//            count ++;
//        }

//    }
//    Console.WriteLine(count);
//}

//9.verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.
//int n = 190;
//int count = 0;
//if (n < 2) 
//{
//	Console.WriteLine("ne sade ne murekkeb");

//}
//else
//{
//	for (int i = 1; i <=n; i++)
//	{
//		if(n % i == 0)
//	{
//		count++;
//	}

//	}
//	if (count > 2) { 
//Console.WriteLine("murekkeb");
//    }
//	else { Console.WriteLine("sade"); }
//}




                                                                           //CLASS TASKS




/////////
//int n = 10;
//int m = 20;
//int sum = n + m;
//Console.WriteLine(sum);

//////////
//bool isMarried = true;
//if (isMarried==true)
//{
//    Console.WriteLine("yes");
//}
//else 
//{
//    Console.WriteLine("no"); 
//}   

//////////////////////
//int[] arr = {1,2,3,4,5}

//for (int i = 0; i <arr.length; i++)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine("////////");
//for (int i = 0; i < arr.length; i++)
//{
//    Console.WriteLine(arr[i]);
//}

///////////////////


//for (int i = a; i <= b; i++) 
//{
//    Console.WriteLine(i);
//}    

//////////////////////
//int a = 1;
//int b = 100;
//for (int i = a; i <= b; i += 2) 
//{
//    if (i % 2 == 0) 
//    { 
//    Console.WriteLine(i);
//    }
//}

////////////////////////

//int a = 1;
//int b = 100;
//int result = 0;
//for (int i = a; i <= b; i ++)
//{
//    if (i % 2 == 1)
//    {
//        result+=i;

//    }
//    Console.WriteLine(result);
//}
//////////////////////////////////

//string[] arr = { "salam", "ksmd", "ejnen", "salam", "salam","salam","hdje" };
//int count = 0;
//for (int i = 0; i < arr.Length; i++) 
//{
//    if (arr[i] == "salam") 
//    {  count++;
//    }
//}
//Console.WriteLine(count);



