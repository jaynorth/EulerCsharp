using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem8
{
    class StringProducts
    {

        public static long[] BiggestProduct(int range, string sequence) {
            long[] productsItems = new  long[range+1];
            int numberOfItems = sequence.Length;
            long biggestProduct = 0;            
            int product = 1;                     

            for (int i = 0; i < numberOfItems - range; i++) {
                for (int j = i; j < i + range; j++) {

                    int p = (int)Char.GetNumericValue(sequence[j]);//convert char number  to integer
                    product *= p; 
                }                
                
                if (product > biggestProduct) {
                    biggestProduct = product;
                    for (int k = 0; k < range; k++) {
                        int value = (int)Char.GetNumericValue(sequence[i + k]);
                        productsItems[k] = value;                        
                    }
                    productsItems[range] = product;                    
                }
                product = 1;
            }

            return productsItems;
        }
    }
}
