using System;
using System.Collections;
public class Program{
	public static string truncLeft(string s){
		string newS="";
		int start=0;
		if(s.Length>=8){start=1;}
		while(s[start]=='0'){start++;}
		for(int i=start;i<s.Length;i++){newS+=s[i];}
	return newS;}
	public static int pow(int a,int b){
int result=1;
		for(int i=0;i<b;i++){result*=a;}
	return result;
	}
	public static int convertBack(string s,int b=2){
		int res=0;
		int p=0;
		bool neg=false;
		if(s.Length>=8 && s[0]=='1'){neg=true;}
		s=truncLeft(s);
		for(int i=s.Length-1;i>=0;i--){
			string d=Convert.ToString(s[i]);
			res+=int.Parse(d)*pow(b,p);
			p++;
		}
	if(neg){res*=-1;}
	return res;}
public static void Main(string[] args){
Console.WriteLine(convertBack("10101111"));
}
}