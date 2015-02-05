package com.stg;

import java.util.ArrayList;
import java.util.List;
//Bryan Hansen quick hack attempt for the Fib program
public class Fibonacci {

	public static void main(String args[]) {
		int input[] = { 5, 7, 8 };

		List<Integer> fibs = new ArrayList<>();

		for (int i : input) {
			if (i == 0 || i == 1) {
				System.out.println("IsFibo");
			} else {
				//its on the expensive side because it
				//recreates the ArrayList of the fibs for 
				//each number. It could easily check to see
				//if the size is larger than the previous fib
				//input. It was just easier to keep the 
				//code concise this way.
				fibs.clear();
				fibs.add(0);
				fibs.add(1);

				for (int j = 2; j <= i; j++) {
					fibs.add(fibs.get(j - 1) + fibs.get(j - 2));
					System.out.println(fibs.get(j));
				}

				System.out.println(fibs);

				if (fibs.contains(i)) {
					System.out.println(i + " IsFibo");
				} else {
					System.out.println(i + " IsNotFibo");
				}
			}
		}
	}
}
