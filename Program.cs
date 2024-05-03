//  OUTPUT ---->>

// prices[TOY]  = 500;
//  prices[BALL]  = 50;
//  prices[BAT]  = 3000;
//  prices[WICKET]  = 800;
// prices[BALOON]  = 5;

// FIRST Type product (CAPS) or E to Exit or I for INV
// Type A for ADD D for Delete
// TOY 
// A
// Tot. of selected itm:
// 1
// prices[TOY]  = 500;
//  prices[BALL]  = 50;
//  prices[BAT]  = 3000;
//  prices[WICKET]  = 800;
// prices[BALOON]  = 5;

// FIRST Type product (CAPS) or E to Exit or I for INV
// Type A for ADD D for Delete
// TOY A
// A
// Please enter item name correctly!
// prices[TOY]  = 500;
//  prices[BALL]  = 50; 
//  prices[BAT]  = 3000;
//  prices[WICKET]  = 800;
// prices[BALOON]  = 5;

// FIRST Type product (CAPS) or E to Exit or I for INV
// Type A for ADD D for Delete
// TOY  
// A
// Tot. of selected itm: 
// 2
// prices[TOY]  = 500;
//  prices[BALL]  = 50;
//  prices[BAT]  = 3000;
//  prices[WICKET]  = 800;
// prices[BALOON]  = 5;

// FIRST Type product (CAPS) or E to Exit or I for INV
// Type A for ADD D for Delete
// TOY
// D
// prices[TOY]  = 500;
//  prices[BALL]  = 50;
//  prices[BAT]  = 3000;
//  prices[WICKET]  = 800;
// prices[BALOON]  = 5;

// FIRST Type product (CAPS) or E to Exit or I for INV
// Type A for ADD D for Delete
// I
// TOY : 1
// prices[TOY]  = 500;
//  prices[BALL]  = 50;
//  prices[BAT]  = 3000;
//  prices[WICKET]  = 800;
// prices[BALOON]  = 5;

// FIRST Type product (CAPS) or E to Exit or I for INV
// Type A for ADD D for Delete
// BAT 
// A
// Tot. of selected itm:
// 1
// prices[TOY]  = 500;
//  prices[BALL]  = 50;
//  prices[BAT]  = 3000;
//  prices[WICKET]  = 800;
// prices[BALOON]  = 5;

// FIRST Type product (CAPS) or E to Exit or I for INV
// Type A for ADD D for Delete
// BAT
// A
// Tot. of selected itm:
// 2
// prices[TOY]  = 500;
//  prices[BALL]  = 50;
//  prices[BAT]  = 3000;
//  prices[WICKET]  = 800;
// prices[BALOON]  = 5;

// FIRST Type product (CAPS) or E to Exit or I for INV
// Type A for ADD D for Delete
// E
// Your amnt:
// 5992

using System;
using System.Collections.Generic;


public class SHOPPE {
	private Dictionary <string, int> cart;
	private Dictionary <string, int> prices;

	public SHOPPE (){
		cart = new Dictionary <string, int>();
        prices = new Dictionary <string,int> ();    
		prices["TOY"]  = 500;
		prices["BALL"]  = 50;
		prices["BAT"]  = 3000;
		prices["WICKET"]  = 800;
		prices["BALOON"]  = 5;

	}

	public void add(string itm){
        if (!prices.ContainsKey(itm)){
            Console.WriteLine("Please enter item name correctly!");
            return;
        }
		if (cart.ContainsKey(itm)){
            cart[itm]+=1;
        }
        else{
            cart[itm]=1;
        }
		Console.WriteLine("Tot. of selected itm: ");
		Console.WriteLine(cart[itm]);
	}

	public void rem(string itm){
		if (!cart.ContainsKey(itm) || cart[itm] == 0){
			Console.WriteLine("No more of such itm");
			return;
		}
		cart[itm]-=1;
	}
	public void show(){
		foreach (var pair in cart){
			Console.Write(pair.Key);
			
			Console.Write(" : ");
			Console.WriteLine(pair.Value);


		}
	}
	public void calc(){
		int tot = 0;
		foreach (var pair in cart){
			tot+=prices[pair.Key]*pair.Value;
		}

		if(tot > 100) {
			tot -= tot/100;
		}
		if(tot > 500) {
			tot -= 2*tot/100;
		}
		if(tot > 2000) {
			tot -= 5*tot/100;
		}
		if(tot > 10000) {
			tot -= 15*tot/100;
		}

		Console.WriteLine("Your amnt: ");
		Console.WriteLine(tot);
	}
}




public class Soln {

	public static void Main (){
		SHOPPE s1 = new SHOPPE();
		while (1==1){
					Console.WriteLine("prices[TOY]  = 500;\n prices[BALL]  = 50; \n prices[BAT]  = 3000;\n prices[WICKET]  = 800;\nprices[BALOON]  = 5;\n");
		            Console.WriteLine("FIRST Type product (CAPS) or E to Exit or I for INV");

					Console.WriteLine("Type A for ADD D for Delete");
					
					string opt1 = Console.ReadLine();
					if(opt1 == "E") break;
					if(opt1 == "I") {
						s1.show();
						continue;
					}					string opt2 = Console.ReadLine();

					switch (opt2)
					{
						case "A":
							s1.add(opt1);
							break;
						case "D":
							s1.rem(opt1);
							break;
						default:
							break;
					}
		}
		s1.calc();
	}
}
