using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiscaleModeling
{
    public partial class mainForm : Form
    {
        public class Matrix
        {

            public int width; //width of CA space
            public int height; // height of CA space
            public int seeds; // number of seeds
            public bool ntype; //neighbourhood type if true then Mora else Von Neuman
            public bool btype; // boundary type if true then Periodic else non periodic
            public int[,] matTable; //Array to store state of cells
            public int[,] matTableTemp; //Array to store state of cell till the end of step
            public Color[] seedsCol; // Array to store seeds colors
            public int[] seedsID; //Array to store ID of seeds
            public Bitmap bmp; //bitmap to display results in pictue box 
            public bool end_flag;//flat to inform if all loops has been made

            public void Matrix_args(int w, int h, int seed, bool n, bool b)
            {
                width = w; //width of matrix
                height = h; // height of matrix
                seeds = seed; // number of seeds
                ntype = n; // neighbourhood type if true then Moora else Von Neuman
                btype = b; // Boundary type if true ten Periodic else Non Periodic
                end_flag = false; //Flag if all data has been processed
            }

            public void matTablegen()
            {   
                //Method to generate CA space tables
                matTable = new int[height, width];
                matTableTemp = new int[height, width];
                bmp = new Bitmap(width, height);

                for(int i=0; i<height; i++)
                {
                    for(int j=0; j<width;j++)
                    {
                        matTable[i, j] = 0;
                        matTableTemp[i, j] = 0;
                    }
                }
            }

            public void genSeedsColor()
            {   
                //Method to generate color table
                seedsCol = new Color[seeds+1];
                seedsID = new int[seeds + 1];
            }

            //----------------------------------------------
            //-------Method to make one full step-----------
            public void step()
            {
                int finish_flag = 0;
                int finish_target = width * height;

                int ul = 0; // Upper left Cell
                int um = 0; // Uper middle Cell
                int ur = 0; // Upper right Cell

                int ml = 0; // Middle left Cell
                int mr = 0; // Middle right Cell

                int dl = 0; // Down left Cell
                int dm = 0; // Down middle Cell
                int dr = 0; // Down right Cell

                //Moore neighbourhoods
                if (ntype==true)
                {   
                    //Periodic boundary
                    if(btype==true)
                    {
                        //loops stars here
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < width; j++)
                            {
                                if (matTable[i, j] > 0)
                                {   
                                    //chceck cell is active and if all data has been processed
                                    finish_flag += 1;
                                    if (finish_flag == finish_target) { end_flag = true; break; }
                                    else { continue; }
                                    
                                }
                                else
                                {

                                    //Middle of space
                                    if ((i > 0 && i < (height - 1)) && (j > 0 && j < (width - 1)))
                                    {
                                        ul = matTable[i - 1, j - 1];
                                        um = matTable[i - 1, j];
                                        ur = matTable[i - 1, j + 1];

                                        ml = matTable[i, j - 1];
                                        mr = matTable[i, j + 1];

                                        dl = matTable[i + 1, j - 1];
                                        dm = matTable[i + 1, j];
                                        dr = matTable[i + 1, j + 1];
                                    }
                                    //Left upper corner
                                    else if (i == 0 && j == 0)
                                    {
                                        ul = matTable[height - 1, width - 1];
                                        um = matTable[height - 1, j];
                                        ur = matTable[height - 1, j + 1];

                                        ml = matTable[i, width - 1];
                                        mr = matTable[i, j + 1];

                                        dl = matTable[i + 1, width - 1];
                                        dm = matTable[i + 1, j];
                                        dr = matTable[i + 1, j + 1];
                                    }
                                    //left down corner
                                    else if ((i == (height - 1)) && j == 0)
                                    {
                                        ul = matTable[i - 1, width - 1];
                                        um = matTable[i - 1, j];
                                        ur = matTable[i - 1, j + 1];

                                        ml = matTable[i, width - 1];
                                        mr = matTable[i, j + 1];

                                        dl = matTable[0, width - 1];
                                        dm = matTable[0, j];
                                        dr = matTable[0, j + 1];
                                    }
                                    //right upper corner
                                    else if (i == 0 && (j == (width - 1)))
                                    {
                                        ul = matTable[height - 1, 0];
                                        um = matTable[height - 1, j];
                                        ur = matTable[height - 1, j - 1];

                                        ml = matTable[i, j - 1];
                                        mr = matTable[i, 0];

                                        dl = matTable[i + 1, j - 1];
                                        dm = matTable[i + 1, j];
                                        dr = matTable[i + 1, 0];
                                    }
                                    //right down corner
                                    else if ((i == (height - 1)) && (j == (width - 1)))
                                    {
                                        ul = matTable[i - 1, j - 1];
                                        um = matTable[i - 1, j];
                                        ur = matTable[i - 1, 0];

                                        ml = matTable[i, j - 1];
                                        mr = matTable[i, 0];

                                        dl = matTable[0, j - 1];
                                        dm = matTable[0, j];
                                        dr = matTable[0, 0];
                                    }
                                    //first column
                                    else if (i > 0 && j == 0)
                                    {
                                        ul = matTable[i - 1, width - 1];
                                        um = matTable[i - 1, j];
                                        ur = matTable[i - 1, j + 1];

                                        ml = matTable[i, width - 1];
                                        mr = matTable[i, j + 1];

                                        dl = matTable[i + 1, width - 1];
                                        dm = matTable[i + 1, j];
                                        dr = matTable[i + 1, j + 1];
                                    }
                                    //last column
                                    else if (i > 0 && j == (width - 1))
                                    {
                                        ul = matTable[i - 1, j - 1];
                                        um = matTable[i - 1, j];
                                        ur = matTable[i - 1, 0];

                                        ml = matTable[i, j - 1];
                                        mr = matTable[i, 0];

                                        dl = matTable[i + 1, j - 1];
                                        dm = matTable[i + 1, j];
                                        dr = matTable[i + 1, 0];
                                    }
                                    //first row
                                    else if (i == 0 && j > 0)
                                    {
                                        ul = matTable[height - 1, j - 1];
                                        um = matTable[height - 1, j];
                                        ur = matTable[height - 1, j + 1];

                                        ml = matTable[i, j - 1];
                                        mr = matTable[i, j + 1];

                                        dl = matTable[i + 1, j - 1];
                                        dm = matTable[i + 1, j];
                                        dr = matTable[i + 1, j + 1];
                                    }
                                    //last row
                                    else if ((i == height - 1) && j > 0)
                                    {
                                        ul = matTable[i - 1, j - 1];
                                        um = matTable[i - 1, j];
                                        ur = matTable[i - 1, j + 1];

                                        ml = matTable[i, j - 1];
                                        mr = matTable[i, j + 1];

                                        dl = matTable[0, j - 1];
                                        dm = matTable[0, j];
                                        dr = matTable[0, j + 1];
                                    }

                                    if (ul > 0) { matTableTemp[i, j] = ul; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID,ul)]); }
                                    else if (um > 0) { matTableTemp[i, j] = um; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, um)]); }
                                    else if (ur > 0) { matTableTemp[i, j] = ur; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, ur)]); }
                                    else if (ml > 0) { matTableTemp[i, j] = ml; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, ml)]); }
                                    else if (mr > 0) { matTableTemp[i, j] = mr; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, mr)]); }
                                    else if (dl > 0) { matTableTemp[i, j] = dl; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, dl)]); }
                                    else if (dm > 0) { matTableTemp[i, j] = dm; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, dm)]); }
                                    else if (dr > 0) { matTableTemp[i, j] = dr; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, dr)]); }

                                }
                           
                            }
                        }//loops ends here
                        for(int i = 0; i<height;i++)
                        {
                            for(int j=0; j<width; j++)
                            {
                                matTable[i, j] = matTableTemp[i, j];
                            }
                        }


                    }// periodic boundary ends here
                    //Non Periodic Boundary starts here
                    else
                    {
                        //loops stars here
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < width; j++)
                            {
                                if (matTable[i, j] > 0)
                                {
                                    finish_flag += 1;
                                    if (finish_flag == finish_target) { end_flag = true; break; }
                                    else { continue; }

                                }
                                else
                                {

                                    //Middle of space
                                    if ((i > 0 && i < (height - 1)) && (j > 0 && j < (width - 1)))
                                    {
                                        ul = matTable[i - 1, j - 1];
                                        um = matTable[i - 1, j];
                                        ur = matTable[i - 1, j + 1];

                                        ml = matTable[i, j - 1];
                                        mr = matTable[i, j + 1];

                                        dl = matTable[i + 1, j - 1];
                                        dm = matTable[i + 1, j];
                                        dr = matTable[i + 1, j + 1];
                                    }
                                    //Left upper corner
                                    else if (i == 0 && j == 0)
                                    {
                                        ul = 0;
                                        um = 0;
                                        ur = 0;

                                        ml = 0;
                                        mr = matTable[i, j + 1];

                                        dl = 0;
                                        dm = matTable[i + 1, j];
                                        dr = matTable[i + 1, j + 1];
                                    }
                                    //left down corner
                                    else if ((i == (height - 1)) && j == 0)
                                    {
                                        ul = 0;
                                        um = matTable[i - 1, j];
                                        ur = matTable[i - 1, j + 1];

                                        ml = 0;
                                        mr = matTable[i, j + 1];

                                        dl = 0;
                                        dm = 0;
                                        dr = 0;
                                    }
                                    //right upper corner
                                    else if (i == 0 && (j == (width - 1)))
                                    {
                                        ul = 0;
                                        um = 0;
                                        ur = 0;

                                        ml = matTable[i, j - 1];
                                        mr = 0;

                                        dl = matTable[i + 1, j - 1];
                                        dm = matTable[i + 1, j];
                                        dr = 0;
                                    }
                                    //right down corner
                                    else if ((i == (height - 1)) && (j == (width - 1)))
                                    {
                                        ul = matTable[i - 1, j - 1];
                                        um = matTable[i - 1, j];
                                        ur = 0;

                                        ml = matTable[i, j - 1];
                                        mr = 0;

                                        dl = 0;
                                        dm = 0;
                                        dr = 0;
                                    }
                                    //first column
                                    else if (i > 0 && j == 0)
                                    {
                                        ul = 0;
                                        um = matTable[i - 1, j];
                                        ur = matTable[i - 1, j + 1];

                                        ml = 0;
                                        mr = matTable[i, j + 1];

                                        dl = 0;
                                        dm = matTable[i + 1, j];
                                        dr = matTable[i + 1, j + 1];
                                    }
                                    //last column
                                    else if (i > 0 && j == (width - 1))
                                    {
                                        ul = matTable[i - 1, j - 1];
                                        um = matTable[i - 1, j];
                                        ur = 0;

                                        ml = matTable[i, j - 1];
                                        mr = 0;

                                        dl = matTable[i + 1, j - 1];
                                        dm = matTable[i + 1, j];
                                        dr = 0;
                                    }
                                    //first row
                                    else if (i == 0 && j > 0)
                                    {
                                        ul = 0;
                                        um = 0;
                                        ur = 0;

                                        ml = matTable[i, j - 1];
                                        mr = matTable[i, j + 1];

                                        dl = matTable[i + 1, j - 1];
                                        dm = matTable[i + 1, j];
                                        dr = matTable[i + 1, j + 1];
                                    }
                                    //last row
                                    else if ((i == height - 1) && j > 0)
                                    {
                                        ul = matTable[i - 1, j - 1];
                                        um = matTable[i - 1, j];
                                        ur = matTable[i - 1, j + 1];

                                        ml = matTable[i, j - 1];
                                        mr = matTable[i, j + 1];

                                        dl = 0;
                                        dm = 0;
                                        dr = 0;
                                    }

                                    if (ul > 0) { matTableTemp[i, j] = ul; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, ul)]); }
                                    else if (um > 0) { matTableTemp[i, j] = um; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, um)]); }
                                    else if (ur > 0) { matTableTemp[i, j] = ur; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, ur)]); }
                                    else if (ml > 0) { matTableTemp[i, j] = ml; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, ml)]); }
                                    else if (mr > 0) { matTableTemp[i, j] = mr; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, mr)]); }
                                    else if (dl > 0) { matTableTemp[i, j] = dl; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, dl)]); }
                                    else if (dm > 0) { matTableTemp[i, j] = dm; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, dm)]); }
                                    else if (dr > 0) { matTableTemp[i, j] = dr; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, dr)]); }

                                }
                            }
                        }//loops ends here
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < width; j++)
                            {
                                matTable[i, j] = matTableTemp[i, j];
                            }
                        }
                    }//Non periodic Boundary ends here

                }//Moore neighbourhoods ends here
                //Neuman neighbourhood starts here
                else
                {
                    //Periodic boundary
                    if (btype == true)
                    {
                        //loops stars here
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < width; j++)
                            {
                                if (matTable[i, j] > 0)
                                {
                                    finish_flag += 1;
                                    if (finish_flag == finish_target) { end_flag = true; break; }
                                    else { continue; }

                                }
                                else
                                {

                                    //Middle of space
                                    if ((i > 0 && i < (height - 1)) && (j > 0 && j < (width - 1)))
                                    {
                                        um = matTable[i - 1, j];

                                        ml = matTable[i, j - 1];
                                        mr = matTable[i, j + 1];

                                        dm = matTable[i + 1, j];
                                    }
                                    //Left upper corner
                                    else if (i == 0 && j == 0)
                                    {
                                        um = matTable[height - 1, j];

                                        ml = matTable[i, width - 1];
                                        mr = matTable[i, j + 1];

                                        dm = matTable[i + 1, j];
                                    }
                                    //left down corner
                                    else if ((i == (height - 1)) && j == 0)
                                    {
                                        um = matTable[i - 1, j];

                                        ml = matTable[i, width - 1];
                                        mr = matTable[i, j + 1];

                                        dm = matTable[0, j];
                                    }
                                    //right upper corner
                                    else if (i == 0 && (j == (width - 1)))
                                    {
                                        um = matTable[height - 1, j];

                                        ml = matTable[i, j - 1];
                                        mr = matTable[i, 0];

                                        dm = matTable[i + 1, j];
                                    }
                                    //right down corner
                                    else if ((i == (height - 1)) && (j == (width - 1)))
                                    {
                                        um = matTable[i - 1, j];

                                        ml = matTable[i, j - 1];
                                        mr = matTable[i, 0];

                                        dm = matTable[0, j];
                                    }
                                    //first column
                                    else if (i > 0 && j == 0)
                                    {
                                        um = matTable[i - 1, j];

                                        ml = matTable[i, width - 1];
                                        mr = matTable[i, j + 1];

                                        dm = matTable[i + 1, j];
                                    }
                                    //last column
                                    else if (i > 0 && j == (width - 1))
                                    {
                                        um = matTable[i - 1, j];

                                        ml = matTable[i, j - 1];
                                        mr = matTable[i, 0];

                                        dm = matTable[i + 1, j];
                                    }
                                    //first row
                                    else if (i == 0 && j > 0)
                                    {
                                        um = matTable[height - 1, j];

                                        ml = matTable[i, j - 1];
                                        mr = matTable[i, j + 1];

                                        dm = matTable[i + 1, j];
                                    }
                                    //last row
                                    else if ((i == height - 1) && j > 0)
                                    {
                                        um = matTable[i - 1, j];

                                        ml = matTable[i, j - 1];
                                        mr = matTable[i, j + 1];

                                        dm = matTable[0, j];
                                    }

                                    if (um > 0) { matTableTemp[i, j] = um; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, um)]); }
                                    else if (ml > 0) { matTableTemp[i, j] = ml; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, ml)]); }
                                    else if (mr > 0) { matTableTemp[i, j] = mr; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, mr)]); }
                                    else if (dm > 0) { matTableTemp[i, j] = dm; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, dm)]); }

                                }

                            }
                        }//loops ends here
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < width; j++)
                            {
                                matTable[i, j] = matTableTemp[i, j];
                            }
                        }


                    }// periodic boundary ends here
                    //Non Periodic Boundary starts here
                    else
                    {
                        //loops stars here
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < width; j++)
                            {
                                if (matTable[i, j] > 0)
                                {
                                    finish_flag += 1;
                                    if (finish_flag == finish_target) { end_flag = true; break; }
                                    else { continue; }

                                }
                                else
                                {

                                    //Middle of space
                                    if ((i > 0 && i < (height - 1)) && (j > 0 && j < (width - 1)))
                                    {
                                        um = matTable[i - 1, j];

                                        ml = matTable[i, j - 1];
                                        mr = matTable[i, j + 1];

                                        dm = matTable[i + 1, j];
                                    }
                                    //Left upper corner
                                    else if (i == 0 && j == 0)
                                    {
                                        um = 0;

                                        ml = 0;
                                        mr = matTable[i, j + 1];

                                        dm = matTable[i + 1, j];
                                    }
                                    //left down corner
                                    else if ((i == (height - 1)) && j == 0)
                                    {

                                        um = matTable[i - 1, j];

                                        ml = 0;
                                        mr = matTable[i, j + 1];

                                        dm = 0;
                                    }
                                    //right upper corner
                                    else if (i == 0 && (j == (width - 1)))
                                    {
                                        um = 0;

                                        ml = matTable[i, j - 1];
                                        mr = 0;

                                        dm = matTable[i + 1, j];
                                    }
                                    //right down corner
                                    else if ((i == (height - 1)) && (j == (width - 1)))
                                    {
                                        um = matTable[i - 1, j];

                                        ml = matTable[i, j - 1];
                                        mr = 0;

                                        dm = 0;
                                    }
                                    //first column
                                    else if (i > 0 && j == 0)
                                    {
                                        um = matTable[i - 1, j];

                                        ml = 0;
                                        mr = matTable[i, j + 1];

                                        dm = matTable[i + 1, j];
                                    }
                                    //last column
                                    else if (i > 0 && j == (width - 1))
                                    {
                                        um = matTable[i - 1, j];

                                        ml = matTable[i, j - 1];
                                        mr = 0;

                                        dm = matTable[i + 1, j];
                                    }
                                    //first row
                                    else if (i == 0 && j > 0)
                                    {
                                        um = 0;

                                        ml = matTable[i, j - 1];
                                        mr = matTable[i, j + 1];

                                        dm = matTable[i + 1, j];
                                    }
                                    //last row
                                    else if ((i == height - 1) && j > 0)
                                    {
                                        um = matTable[i - 1, j];

                                        ml = matTable[i, j - 1];
                                        mr = matTable[i, j + 1];

                                        dm = 0;
                                    }

                                    if (um > 0) { matTableTemp[i, j] = um; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, um)]); }
                                    else if (ml > 0) { matTableTemp[i, j] = ml; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, ml)]); }
                                    else if (mr > 0) { matTableTemp[i, j] = mr; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, mr)]); }
                                    else if (dm > 0) { matTableTemp[i, j] = dm; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, dm)]); }

                                }

                            }
                        }//loops ends here
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < width; j++)
                            {
                                matTable[i, j] = matTableTemp[i, j];
                            }
                        }
                    }//Non periodic Boundary ends here
                }//Neuman neighbourhoods ends here
            }

        }
        // testing class to generate seed object, not necessery
        public class Seed
        {
            public int X;
            public int Y;
            public int ID;

            public Seed(int x, int y, int id)
                {
                    X = x;
                    Y = y;
                    ID = id;
                }
        }

        //testing varaibles to store values from text boxes, not neccesery if Matrix attributes are public
        int width;
        int height;
        int seeds;
        bool ntype;
        bool btype;

        //timer to display animation
        Timer t = new Timer();
        Matrix m1 = new Matrix();

        public mainForm()
        {
            InitializeComponent();
            //Initialize begining view
            seed_num.Enabled = false;
            seed_button.Enabled = false;
            more_check.Enabled = false;
            neuman_check.Enabled = false;
            p_check.Enabled = false;
            NonP_check.Enabled = false;
            start_button.Enabled = false;
            Animation_button.Enabled = false;
            pause_button.Enabled = false;
            nexts_button.Enabled = false;
            export_jpg_button.Enabled = false;
            export_txt_button.Enabled = false;
            import_cond_button.Enabled = false;
            import_cond_button.Visible = false;


            t.Interval = 200; // speed of animation
            t.Tick += new EventHandler(this.Animation_button_Click);

        }

        private void size_button_Click(object sender, EventArgs e)
        {
            //chceck if all values are int only and width and height >0
            int parse;
            if(!int.TryParse(width_txt.Text, out parse) || !int.TryParse(heigh_txt.Text, out parse))
            {
                MessageBox.Show("Please insert numbers only");
            }
            else
            {
                if(Int32.Parse(width_txt.Text)>0 && Int32.Parse(heigh_txt.Text)>0)
                        {
                            width = Int32.Parse(width_txt.Text);
                            height = Int32.Parse(heigh_txt.Text);
                            seed_num.Enabled = true;
                            seed_button.Enabled = true;
                        }
                else
                {
                    MessageBox.Show("width and height must be > 0");
                }
            }


        }

        private void seed_button_Click(object sender, EventArgs e)
        {
            //chceck if values are numbers only and >0
            int parse;
            if(!int.TryParse(seed_num.Value.ToString(), out parse))
            {
                MessageBox.Show("Please insert int number only");
            }
            else
            {   
                if(Int32.Parse(seed_num.Value.ToString())>0)
                {
                    seeds = Int32.Parse(seed_num.Value.ToString());
                    more_check.Enabled = true;
                    neuman_check.Enabled = true;
                    p_check.Enabled = true;
                    NonP_check.Enabled = true;
                    start_button.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Number of seeds must be > 0");
                }

            }

        }

        private void start_button_Click(object sender, EventArgs e)
        {
            //Generate CA space, seeds, colors targets...
            if(width>0 && height >0 && seeds >0)
            {
                if (more_check.Checked) { ntype = true; }
                else { ntype = false; }

                if (p_check.Checked) { btype = true; }
                else { btype = false; }

                width_txt.Enabled = false;
                heigh_txt.Enabled = false;
                size_button.Enabled = false;
                seed_num.Enabled = false;
                seed_button.Enabled = false;
                more_check.Enabled = false;
                neuman_check.Enabled = false;
                p_check.Enabled = false;
                NonP_check.Enabled = false;


                m1.Matrix_args(width, height, seeds, ntype, btype);
                pic_box.Width = m1.width;
                pic_box.Height = m1.height;
                m1.matTablegen();
                m1.genSeedsColor();
                Random rnd = new Random();

                for(int i=1; i<m1.seeds+1;i++)
                {
                    int ok = 0;

                    do
                    {
                        int X = rnd.Next(0, width);
                        int Y = rnd.Next(0, height);
                        if (m1.matTable[Y, X] == 0)
                        {
                            Seed s1 = new Seed(Y, X, i);
                            ok = 1;
                            m1.matTable[Y, X] = i;
                            m1.matTableTemp[Y, X] = i;
                            Color randCol = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                            m1.bmp.SetPixel(X, Y, randCol);
                            m1.seedsID[i] = i;
                            m1.seedsCol[i] = randCol;
                        }
                    } while (ok == 0);

                    pic_box.Image = m1.bmp;


                }
                Animation_button.Enabled = true;
                pause_button.Enabled = true;
                nexts_button.Enabled = true;
                export_jpg_button.Enabled = true;
                export_txt_button.Enabled = true;
            }
            else
            {
                MessageBox.Show("insert values first");
            }

        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            //reset everything
            width_txt.Enabled = true;
            heigh_txt.Enabled = true;
            size_button.Enabled = true;
            seed_num.Enabled = false;
            seed_button.Enabled = false;
            more_check.Enabled = false;
            neuman_check.Enabled = false;
            p_check.Enabled = false;
            NonP_check.Enabled = false;
            start_button.Enabled = false;
            Animation_button.Enabled = false;
            pause_button.Enabled = false;
            nexts_button.Enabled = false;
            export_jpg_button.Enabled = false;
            export_txt_button.Enabled = false;
            import_cond_button.Enabled = false;
            import_cond_button.Visible = false;

            width = 0;
            //m1.width = 0;
            height = 0;
            //m1.height = 0;
            seeds = 0;
            //m1.seeds = 0;


    }

        private void nexts_button_Click(object sender, EventArgs e)
        {   
            //one step button
            m1.step();
            pic_box.Image = m1.bmp;
        }

        private void Animation_button_Click(object sender, EventArgs e)
        {   
            //animation button
            Animation_button.Enabled = false;
            pause_button.Enabled = true;
            t.Start();
            m1.step();
            pic_box.Image = m1.bmp;
            if(m1.end_flag==true)
            {
                t.Stop();
                MessageBox.Show("All data processed");
            }
        }

        private void pause_button_Click(object sender, EventArgs e)
        {
            t.Stop();
            pause_button.Enabled = false;
            Animation_button.Enabled = true;
        }

        private void export_jpg_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images| *.jpg";
            System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Jpeg;
            if(sfd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                pic_box.Image.Save(sfd.FileName, format);
            }
            
        }

        private void export_txt_button_Click(object sender, EventArgs e)
        {   
            //convert size of arry to 3 columns X,Y,State

            //set new tab size
            int tab_size = m1.height * m1.width;

            //initialize new table
            int[,] export_table = new int[tab_size, 3];
            int tab_poz = 0;
            for(int i=0;i<m1.height;i++)
            {               
                for(int j=0; j<m1.width;j++)
                {   
                    //position in new tab
                    tab_poz = (i * m1.height)+j;
                    export_table[tab_poz, 0] = i;
                    export_table[tab_poz, 1] = j;
                    export_table[tab_poz, 2] = m1.matTable[i, j];
                }
            }


            //Create file if not exists and save
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File | *.txt";
            if(sfd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                for (int i = 0; i < tab_size; i++)
                {
                    string line = export_table[i, 0].ToString() + ',' + export_table[i, 1].ToString() + ',' + export_table[i, 2].ToString()+Environment.NewLine;
                    if(i==0)
                    {   
                        //write first row
                        System.IO.File.WriteAllText(sfd.FileName, line);
                    }
                    else
                    {   
                        //append all next rows
                        System.IO.File.AppendAllText(sfd.FileName, line);
                    }
                    
                }
                MessageBox.Show("Data export completed");
            }

        }

        private void import_button_Click(object sender, EventArgs e)
        {   
            OpenFileDialog ofd = new OpenFileDialog();
            
            //list to store lines
            List<string> temp_list = new List<string>();

            if(ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {   
                //add lines to the list
                string line;
                System.IO.StreamReader file = new System.IO.StreamReader(ofd.FileName);
                while((line=file.ReadLine())!=null)
                {
                    temp_list.Add(line);
                }
                file.Close();

                //generate new 3 colums table: X,Y,State
                int[,] import_table = new int[temp_list.Count(), 3];

                //initialize width and height variables
                int sp_width = 0;
                int import_seeds = 0;

                //list to store seeds ID
                List<int> impSeedsID = new List<int>();

                //random to generate random colors
                Random rnd = new Random();
                for (int i=0; i<temp_list.Count();i++)
                {   
                    //isnert vales to arry
                    import_table[i, 0] = Array.ConvertAll(temp_list[i].Split(','), int.Parse)[0];
                    import_table[i, 1] = Array.ConvertAll(temp_list[i].Split(','), int.Parse)[1];
                    import_table[i, 2] = Array.ConvertAll(temp_list[i].Split(','), int.Parse)[2];
                    if(import_table[i, 0]==0)
                    {
                        sp_width += 1;
                    }
                    if(import_table[i, 2]>0)
                    {                       
                        if(impSeedsID.Contains(import_table[i, 2])==false)
                        {
                            import_seeds += 1;
                            impSeedsID.Add(import_table[i, 2]);
                        }
                        
                    }
                }

                //set Matrix object values
                m1.width = sp_width;
                int sp_height = temp_list.Count()/ sp_width;
                m1.height = sp_height;
                m1.seeds = import_seeds;
                m1.matTablegen();
                m1.genSeedsColor();

                //genrate colors and put it into Matrix object
                for(int i = 1; i <m1.seeds+1; i++)
                {   

                    Color randCol = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    m1.seedsCol[i] = randCol;
                    m1.seedsID[i] = impSeedsID[i - 1];
                }


                //Generate finall Array base on actual width and height
                int tab_poz = 0;
                for (int i=0; i<m1.height;i++)
                {
                    for(int j=0;j<m1.width;j++)
                    {
                        tab_poz = (i * m1.height) + j;
                        m1.matTable[i, j] = import_table[tab_poz, 2];
                        m1.matTableTemp[i, j] = import_table[tab_poz, 2];
                        if (m1.matTable[i, j]>0)
                        {
                            m1.bmp.SetPixel(j, i, m1.seedsCol[Array.IndexOf(m1.seedsID,m1.matTable[i, j])]);
                        }
                    }
                }


                //set final view
                pic_box.Width = m1.width;
                pic_box.Height = m1.height;
                pic_box.Image = m1.bmp;
                start_button.Enabled = false;
                more_check.Enabled = true;
                neuman_check.Enabled = true;
                p_check.Enabled = true;
                NonP_check.Enabled = true;
                import_cond_button.Enabled = true;
                import_cond_button.Visible = true;



            }

        }

        private void import_cond_button_Click(object sender, EventArgs e)
        {   
            //Button to set conditions after import data
            if (more_check.Checked) { ntype = true; }
            else { ntype = false; }

            if (p_check.Checked) { btype = true; }
            else { btype = false; }

            m1.ntype = ntype;
            m1.btype = btype;
            Animation_button.Enabled = true;
            pause_button.Enabled = true;
            nexts_button.Enabled = true;
            export_jpg_button.Enabled = true;
            export_txt_button.Enabled = true;
            start_button.Enabled = true;
            import_cond_button.Enabled = false;
            import_cond_button.Visible = false;
            width_txt.Enabled = false;
            heigh_txt.Enabled = false;
            size_button.Enabled = false;
            seed_num.Enabled = false;
            seed_button.Enabled = false;
            more_check.Enabled = false;
            neuman_check.Enabled = false;
            p_check.Enabled = false;
            NonP_check.Enabled = false;
        }
    }
}
