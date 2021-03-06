﻿using System;

namespace OOP_T1_P3
{
	class MainClass
	{
		public static void Main(string[] args)
		{	
			Resources[] arrayResources = new Resources[3];
			arrayResources[0] = new Resources("W600", true, ResourceCategory.Worker);
			arrayResources[1] = new Resources("D700", false, ResourceCategory.Document);
			arrayResources[2] = new Resources("V800", true, ResourceCategory.Vehicle);
			DeployAll(arrayResources);
			Console.ReadLine();
		}

		public static void DeployAll( Resources[] Resources) 
		{
			for (int i = 0; i < Resources.Length; i++)
			{
				Console.WriteLine("ID:{0}\nStatus:{1}\nCategory:{2}\n{3}\n", Resources[i].Id, Resources[i].Status, Resources[i].Category, Resources[i].deploy());
			} 
		}
	}
}
