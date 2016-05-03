using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoutzOCRX.Engine
{
    public class swTest
    {
        public static int swtesting(Objects.pxStream myStream)
        {
            int iLineValue = 0;
            int iWidth = myStream.Width;
            int iHeight = myStream.Height;
            int i22h = 0;
            int i44h = 0;
            int i66h = 0;
            int i22v = 0;
            int i44v = 0;
            int i66v = 0;
            int oneThird = (int)iWidth / 3;
            int twoThird = oneThird * 2;

            for (int y = 0; y < iHeight; y++)
            { 
                for (int x = 0; x < iWidth; x++)
                {
                    if (myStream[x, y])
                        iLineValue++;
                }

                if (y == 22)
                {
                    i22h = iLineValue;
                    iLineValue = 0;
                }
                if (y == 44)
                {
                    i44h = iLineValue;
                    iLineValue = 0;
                }

                /*
                if (y == 65)
                {
                    i66h = iLineValue;
                    //iLineValue = 0;
                }
                */
             
            }
            i66h = iLineValue;


            for (int x = 0; x < iWidth; x++)
            {
                for (int y = 0; y < iHeight; y++) 
                {
                    if (myStream[x, y])
                        iLineValue++;

                }

                if (x == (int)(iWidth / 3))
                {
                    i22v = iLineValue;
                    iLineValue = 0;
                }
                if (x == (int)(iWidth /3)*2)
                {
                    i44v = iLineValue;
                    iLineValue = 0;
                }
                if (x == 65)
                {
                    i66v = iLineValue;
                    //iLineValue = 0;
                }

            }
            i66v = iLineValue;

            MessageBox.Show(String.Format("first: {0}, \nsecond {1}, \nthird {2}", i22h, i44h, i66h));
            MessageBox.Show(String.Format("first: {0}, \nsecond {1}, \nthird {2}", i22v, i44v, i66v));

            return 0;

        }

        public static int swtesting2(Objects.pxStream myStream)
        {
            int iLeftTop = 0;
            int iRightTop = 0;
            int iLeftBottom = 0;
            int iRightBottom = 0;
            int iCenter = 0;

            int iWidth = myStream.Width;
            int iHeight = myStream.Height;

            int iAx = 0;
            int iBx = (int)(iWidth / 4);
            int iCx = 0;
            int iDx = iBx;

            int iAy = (int)(iHeight *.2);
            int iBy = iAy;
            int iCy = (int)(iHeight * .4);
            int iDy = iCy;

            int iEx = (int)(iWidth * .75);
            int iEy = iAy;
            int iFx = iWidth;
            int iFy = iEy;
            int iGx = iEx;
            int iGy = iCy;
            int iHx = iWidth;
            int iHy = iGy;

            int iIx = iAx;
            int iIy = (int)(iHeight * .6);
            int iJx = iBx;
            int iJy = iIy;
            int iKx = iIx;
            int iKy = (int)(iHeight * .8);
            int iLx = iJx;
            int iLy = iKy;

            int iMx = iGx;
            int iMy = iJy;
            int iNx = iWidth;
            int iNy = iMy;
            int iOx = iMx;
            int iOy = iLy;
            int iPx = iWidth;
            int iPy = iOy;

            int isa0 = 0;
            int isa1 = 0;
            int isa2 = 0;
            int isa3 = 0;
            int isa4 = 0;
            int isa5 = 0;
            int isa6 = 0;
            int isa7 = 0;
            int isa8 = 0;
            int isa9 = 0;





            for (int y = iAy; y < iCy; y++)
            {
                for (int x = 0; x < iBx; x++)
                {
                    if (myStream[x, y])
                        iLeftTop++;
                }
            }

            for (int y = iEy; y < iGy; y++)
            {
                for (int x = iEx; x < iFx; x++)
                {
                    if (myStream[x, y])
                        iRightTop++;
                }
            }

            for (int y = iJy; y < iLy; y++)
            {
                for (int x = iIx; x < iJx; x++)
                {
                    if (myStream[x, y])
                        iLeftBottom++;
                }
            }

            for (int y = iMy; y < iOy; y++)
            {
                for (int x = iMx; x < iNx; x++)
                {
                    if (myStream[x, y])
                        iRightBottom++;
                }
            }

            for (int y = iDy; y < iJy; y++)
            {
                for (int x = iDx; x < iGx; x++)
                {
                    if (myStream[x, y])
                        iCenter++;
                }
            }



            MessageBox.Show(String.Format("first: {0}, \nsecond {1}, \nsecond {2}, \nsecond {3}, \nsecond {4}", iLeftTop, iRightTop, iLeftBottom, iRightBottom, iCenter));

            //check TopLeft
            if (iLeftTop < 15)
            {
                isa1++;
                isa4++;
                isa7++;

                isa0--;
                isa5--;
                isa6--;
                isa8--;
                isa9--;
            }

            if (iLeftTop >= 15 && iLeftTop < 100)
            {
                isa2++;
                isa3++;
            }

            if (iLeftTop >= 100)
            {
                isa0++;
                isa5++;
                isa6++;
                isa8++;
                isa9++;

                isa1--;
                isa4--;
                isa7--;
            }

            //checking for RightTop
            if (iRightTop < 15)
            {
                isa5++;
                isa7++;

                isa0--;
                isa2--;
                isa3--;
                isa8--;
                isa9--;
            }

            if (iRightTop >= 15 && iRightTop < 100)
            {
                isa1++;
                isa4++;
                isa6++;
            }

            if (iRightTop >= 100)
            {          
                isa0++;
                isa2++;
                isa3++;
                isa8++;
                isa9++;

                isa5--;
                isa7--;
            }

            //checking for LeftBottom
            if (iLeftBottom < 15)
            {
                isa1++;
                isa7++;

                isa0--;
                isa6--;
                isa8--;
            }

            if (iLeftBottom >= 15 && iLeftBottom < 100)
            {
                isa2++;
                isa3++;
                isa4++;
                isa5++;
                isa9++;
            }

            if (iLeftBottom >= 100)
            {              
                isa0++;
                isa6++;
                isa8++;

                isa1--;
                isa7--;
            }

            //checking for RightBottom
            if (iRightBottom < 15)
            {
                isa2++;
                isa7++;

                isa0--;
                isa3--;
                isa4--;
                isa5--;
                isa6--;
                isa8--;
                isa9--;
            }

            if (iRightBottom >= 15 && iRightBottom < 100)
            {
                isa1++;

            }

            if (iRightBottom >= 100)
            {               
                isa0++;
                isa3++;
                isa4++;
                isa5++;
                isa6++;
                isa8++;
                isa9++;

                isa2--;
                isa7--;
            }

            //checking for Center
            if (iCenter < 15)
            {
                isa0++; 

                isa3--;
                isa4--;
                isa5--;
                isa6--;
                isa7--;
                isa8--;
                isa9--;
            }

            if (iCenter >= 15 && iCenter < 100)
            {
                isa1++;
                isa2++;
            }

            if (iCenter >= 100)
            {
                isa0--;

                isa3++;
                isa4++;
                isa5++;
                isa6++;
                isa7++;
                isa8++;
                isa9++;
            }

            MessageBox.Show(String.Format("0: {0}, \n1 {1}, \n2{2}, \n3 {3}, \n4 {4}, \n5 {5}, \n6 {6}, \n7 {7}, \n8 {8}, \n9 {9}", isa0, isa1, isa2, isa3, isa4, isa5, isa6, isa7, isa8, isa9));


            return 0;

        }


    }
}
