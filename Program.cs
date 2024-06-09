using System;
using System.Collections.Generic;
using System.IO;

namespace Zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent risus nisl, accumsan vel nisl et, efficitur commodo quam. Integer placerat magna sit amet nisl iaculis, sit amet fermentum odio viverra. Praesent vitae tellus nec dui lacinia pulvinar. Phasellus posuere vulputate sem, accumsan tincidunt enim tincidunt finibus. Vivamus pharetra gravida leo eu suscipit. Vestibulum id egestas ex. Sed consectetur mattis placerat. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Vivamus fermentum aliquam ex vitae efficitur. In semper vitae metus nec maximus. Vestibulum volutpat sem laoreet, suscipit diam sit amet, rutrum est. Fusce ac tempor elit. Aliquam luctus elementum justo et pretium.\r\n\r\nDonec fringilla varius ex at commodo. Integer non sem id risus accumsan hendrerit eget sit amet lacus. Vestibulum sit amet tempus risus. Pellentesque cursus sed erat in congue. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Etiam pharetra sollicitudin sem at fringilla. Duis risus massa, interdum a consequat consectetur, lacinia eget tortor. Mauris scelerisque augue felis, ut vulputate libero pretium id. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse accumsan massa a ipsum ultrices luctus.\r\n\r\nDonec et leo augue. Praesent non purus sodales, tempor nibh non, viverra neque. Ut ligula lectus, volutpat eget posuere ac, accumsan eu urna. Sed eleifend leo eros, ut molestie magna cursus eget. Proin scelerisque at nulla sit amet ornare. Quisque vel dui ex. Etiam tempus turpis non risus rhoncus aliquet. Suspendisse euismod at velit sit amet malesuada. Vestibulum vel nisl sed lectus porttitor sollicitudin. Integer eu tellus sit amet tortor facilisis condimentum. Sed imperdiet ac dui id vestibulum. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Maecenas ut lorem tristique, viverra ex ac, cursus tellus. Etiam vel nulla a erat tristique placerat. Sed viverra, turpis at dapibus rutrum, mi urna lacinia massa, et lacinia nisi augue laoreet ante.\r\n\r\nMauris cursus feugiat auctor. Nullam consectetur, neque ut commodo rutrum, quam massa lacinia nisl, in venenatis tortor dui blandit mauris. Pellentesque mattis dolor id ultrices pretium. Praesent egestas tristique nunc, sed laoreet leo varius vitae. Mauris feugiat lectus ac orci tristique, ut congue orci ornare. Sed et bibendum ligula, a rhoncus massa. Suspendisse porttitor, metus at efficitur tincidunt, purus sem iaculis ante, sed malesuada mauris libero sit amet sem. In vestibulum, arcu finibus suscipit hendrerit, ligula leo placerat dolor, eu congue arcu est sit amet ligula. In mattis tincidunt mauris, ut iaculis odio dictum at. Aliquam condimentum, diam non volutpat pulvinar, neque magna luctus enim, non fringilla libero dui non eros. Curabitur pretium tincidunt magna eu ultricies.\r\n\r\nDuis vel posuere tortor. Praesent sagittis feugiat dui ut euismod. Curabitur augue quam, luctus et enim ut, scelerisque maximus tellus. Nulla imperdiet tortor eget venenatis lobortis. Vestibulum rutrum accumsan molestie. Phasellus pulvinar dui eget consequat consequat. Curabitur egestas pulvinar orci in rhoncus.\r\n\r\nEtiam sodales erat at est mollis, sed euismod nibh faucibus. Sed lacinia tortor in feugiat fringilla. Nulla ultrices est a tellus efficitur, quis dictum odio fringilla. Nulla vehicula purus quis sapien tincidunt dignissim. Etiam lacinia posuere elit in venenatis. Sed placerat justo eleifend, bibendum mi in, pharetra urna. Donec quis tempor justo. Praesent diam odio, mattis non mauris ut, posuere cursus orci. Integer quis nunc sed erat tempor condimentum. Suspendisse sodales odio lacus, et fermentum magna eleifend vitae. Aliquam iaculis leo et auctor interdum.\r\n\r\nVestibulum suscipit elementum leo, in molestie ex efficitur id. Nunc nec justo quis felis rhoncus faucibus. Donec venenatis lacus eget pharetra condimentum. Proin pellentesque purus mi, vitae consequat sem consequat id. Donec tortor quam, finibus eu congue et, molestie vel lectus. Pellentesque gravida sapien vel condimentum dapibus. Nulla fringilla, nulla id imperdiet venenatis, massa nunc lobortis eros, a posuere libero libero quis velit. Proin consequat faucibus consectetur. Suspendisse vel mi ac neque ullamcorper facilisis. Proin scelerisque euismod turpis, sit amet commodo purus faucibus sed. Praesent maximus mi nec varius sagittis. Nunc cursus erat nibh, eget condimentum mi consequat feugiat.\r\n\r\nCras eget tristique tortor. Mauris consectetur dictum felis, eget mattis lorem vulputate ut. Donec congue ullamcorper blandit. Nulla facilisi. Fusce faucibus mattis purus, et consequat erat rutrum ut. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum blandit, sem non commodo imperdiet, nisl neque luctus ex, ut laoreet odio turpis sed odio. Interdum et malesuada fames ac ante ipsum primis in faucibus. Sed consequat volutpat scelerisque.\r\n\r\nPellentesque sollicitudin mi id facilisis laoreet. Vestibulum aliquet vel turpis quis pellentesque. Sed dapibus dolor et dui suscipit, ac commodo neque rutrum. Cras faucibus dapibus mi sit amet semper. Sed quis posuere dui. Mauris ut sem a libero dictum placerat. Phasellus non urna purus. Aliquam erat volutpat. In vel purus pretium, mollis ipsum vel, sollicitudin sem. Vivamus tincidunt arcu id lectus cursus euismod.\r\n\r\nCras consequat lobortis sapien eget gravida. Quisque elit diam, cursus eu turpis vel, viverra viverra tortor. Ut et egestas mi. Nam ut sollicitudin felis. Nulla a sapien facilisis, porttitor neque nec, pharetra dui. Quisque efficitur, est id tempus vehicula, lacus sem efficitur dui, sed sodales odio felis ac tortor. Nullam volutpat interdum lectus a rutrum. Aenean euismod commodo leo et maximus. Fusce vitae sapien velit. Aliquam hendrerit placerat arcu a dapibus. Aliquam ac venenatis diam, quis convallis felis. Nam tempor magna ligula.\r\n\r\nSed ante quam, pharetra vel pretium sit amet, maximus vel nulla. Fusce a nisi at velit sodales dapibus eu nec lectus. Vivamus suscipit vitae neque at rutrum. Sed id consequat quam, sed malesuada enim. Integer viverra suscipit ipsum eu viverra. Pellentesque ac dolor in felis venenatis molestie. Vivamus ut mauris tristique, posuere odio et, facilisis diam. Donec at ornare arcu, vel elementum purus. Morbi egestas elit ornare, feugiat turpis vitae, commodo ligula. Maecenas a pharetra magna. Proin volutpat nunc nec tellus pretium, vel auctor velit viverra. Sed vel elit iaculis, sollicitudin nisi ac, faucibus mauris. Duis vitae euismod nibh, nec bibendum lorem. Aenean finibus convallis dolor. Donec pharetra, tellus in rhoncus porta, mi nisi ullamcorper leo, nec tincidunt felis massa eget diam. Curabitur sed mi eget diam tempus bibendum. Vestibulum tempor eu elit eu pretium. Cras gravida quis dolor.";

            string encryptedText = Encrypt(inputText, 3);
            string transposedText = ColumnarTranspose(encryptedText, 8);

            File.WriteAllText("encrypted_text.txt", transposedText);
        }

        static string Encrypt(string input, int shift)
        {
            char[] buffer = input.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];

                if (char.IsLetter(letter))
                {
                    char d = char.IsUpper(letter) ? 'A' : 'a';
                    letter = (char)((((letter + shift) - d) % 26) + d);
                }

                buffer[i] = letter;
            }
            return new string(buffer);
        }

        static string ColumnarTranspose(string input, int numColumns)
        {
            int numRows = (int)Math.Ceiling((double)input.Length / numColumns);
            char[,] table = new char[numRows, numColumns];

            int k = 0;
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numColumns; j++)
                {
                    if (k < input.Length)
                    {
                        table[i, j] = input[k++];
                    }
                    else
                    {
                        table[i, j] = ' ';
                    }
                }
            }

            char[] transposed = new char[numRows * numColumns];
            k = 0;
            for (int j = 0; j < numColumns; j++)
            {
                for (int i = 0; i < numRows; i++)
                {
                    transposed[k++] = table[i, j];
                }
            }

            return new string(transposed);
        }
    }
}
