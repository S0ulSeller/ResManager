using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResManager
{
    public partial class ResManagerForm : Form
    {
        readonly DataTable dataTable = new DataTable();
        public ResManagerForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ParseResItem(@"C:\Users\Daniel\Source\Repos\MagnoliaFlyFF\Resource\propItem.txt", new char[] { '\t' });
        }

        public void ParseResItem(string path, char[] delimiter)
        {
            StreamReader streamReader = new StreamReader(path);
            string[] columnheaders = streamReader.ReadLine().Split(delimiter);

            foreach (string columnheader in columnheaders)
            {
                dataTable.Columns.Add(columnheader);
            }

            while (streamReader.Peek() > 0)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow.ItemArray = streamReader.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                dataTable.Rows.Add(dataRow);
            }


            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                listBox1.Items.Add(dataTable.Rows[i][1].ToString().Trim('"'));
            }


        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemID.Text = dataTable.Rows[listBox1.SelectedIndex][0].ToString();
            name.Text = dataTable.Rows[listBox1.SelectedIndex][1].ToString();
            number.Text = dataTable.Rows[listBox1.SelectedIndex][2].ToString();
            maxStackSize.Text = dataTable.Rows[listBox1.SelectedIndex][3].ToString();
            itemKind1.Text = dataTable.Rows[listBox1.SelectedIndex][4].ToString();
            itemKind2.Text = dataTable.Rows[listBox1.SelectedIndex][5].ToString();
            itemKind3.Text = dataTable.Rows[listBox1.SelectedIndex][6].ToString();
            job.Text = dataTable.Rows[listBox1.SelectedIndex][7].ToString();
            permanence.Text = dataTable.Rows[listBox1.SelectedIndex][8].ToString();
            usable.Text = dataTable.Rows[listBox1.SelectedIndex][9].ToString();
            sex.Text = dataTable.Rows[listBox1.SelectedIndex][10].ToString();
            cost.Text = dataTable.Rows[listBox1.SelectedIndex][11].ToString();
            endurance.Text = dataTable.Rows[listBox1.SelectedIndex][12].ToString();
            abrasion.Text = dataTable.Rows[listBox1.SelectedIndex][13].ToString();
            maxRepair.Text = dataTable.Rows[listBox1.SelectedIndex][14].ToString();
            handed.Text = dataTable.Rows[listBox1.SelectedIndex][15].ToString();
            flag.Text = dataTable.Rows[listBox1.SelectedIndex][16].ToString();
            parts.Text = dataTable.Rows[listBox1.SelectedIndex][17].ToString();
            partSub.Text = dataTable.Rows[listBox1.SelectedIndex][18].ToString();
            partFile.Text = dataTable.Rows[listBox1.SelectedIndex][19].ToString();
            exclusive.Text = dataTable.Rows[listBox1.SelectedIndex][20].ToString();
            basePartsIgnore.Text = dataTable.Rows[listBox1.SelectedIndex][21].ToString();
            itemLevel.Text = dataTable.Rows[listBox1.SelectedIndex][22].ToString();
            itemRare.Text = dataTable.Rows[listBox1.SelectedIndex][23].ToString();
            shopable.Text = dataTable.Rows[listBox1.SelectedIndex][24].ToString();
            log.Text = dataTable.Rows[listBox1.SelectedIndex][25].ToString();
            charged.Text = dataTable.Rows[listBox1.SelectedIndex][26].ToString();
            linkKindBullet.Text = dataTable.Rows[listBox1.SelectedIndex][27].ToString();
            linkKind.Text = dataTable.Rows[listBox1.SelectedIndex][28].ToString();
            abilityMin.Text = dataTable.Rows[listBox1.SelectedIndex][29].ToString();
            abilityMax.Text = dataTable.Rows[listBox1.SelectedIndex][30].ToString();
            itemType.Text = dataTable.Rows[listBox1.SelectedIndex][31].ToString();
            itemEAtk.Text = dataTable.Rows[listBox1.SelectedIndex][32].ToString();
            parry.Text = dataTable.Rows[listBox1.SelectedIndex][33].ToString();
            blockRating.Text = dataTable.Rows[listBox1.SelectedIndex][34].ToString();
            addSkillMin.Text = dataTable.Rows[listBox1.SelectedIndex][35].ToString();
            addSkillMax.Text = dataTable.Rows[listBox1.SelectedIndex][36].ToString();
            atkStyle.Text = dataTable.Rows[listBox1.SelectedIndex][37].ToString();
            weaponType.Text = dataTable.Rows[listBox1.SelectedIndex][38].ToString();
            itemAtkOrder1.Text = dataTable.Rows[listBox1.SelectedIndex][39].ToString();
            itemAtkOrder2.Text = dataTable.Rows[listBox1.SelectedIndex][40].ToString();
            itemAtkOrder3.Text = dataTable.Rows[listBox1.SelectedIndex][41].ToString();
            itemAtkOrder4.Text = dataTable.Rows[listBox1.SelectedIndex][42].ToString();
            continousPain.Text = dataTable.Rows[listBox1.SelectedIndex][43].ToString();
            shellQuantity.Text = dataTable.Rows[listBox1.SelectedIndex][44].ToString();
            recoil.Text = dataTable.Rows[listBox1.SelectedIndex][45].ToString();
            loadingTime.Text = dataTable.Rows[listBox1.SelectedIndex][46].ToString();
            adjHitRate.Text = dataTable.Rows[listBox1.SelectedIndex][47].ToString();
            attackSpeed.Text = dataTable.Rows[listBox1.SelectedIndex][48].ToString();
            dmgShift.Text = dataTable.Rows[listBox1.SelectedIndex][49].ToString();
            attackRange.Text = dataTable.Rows[listBox1.SelectedIndex][50].ToString();
            probability.Text = dataTable.Rows[listBox1.SelectedIndex][51].ToString();
            destParam1.Text = dataTable.Rows[listBox1.SelectedIndex][52].ToString();
            destParam2.Text = dataTable.Rows[listBox1.SelectedIndex][53].ToString();
            destParam3.Text = dataTable.Rows[listBox1.SelectedIndex][54].ToString();
            adjParamVal1.Text = dataTable.Rows[listBox1.SelectedIndex][55].ToString();
            adjParamVal2.Text = dataTable.Rows[listBox1.SelectedIndex][56].ToString();
            adjParamVal3.Text = dataTable.Rows[listBox1.SelectedIndex][57].ToString();
            chgParamVal1.Text = dataTable.Rows[listBox1.SelectedIndex][58].ToString();
            chgParamVal2.Text = dataTable.Rows[listBox1.SelectedIndex][59].ToString();
            chgParamVal3.Text = dataTable.Rows[listBox1.SelectedIndex][60].ToString();
            destData1.Text = dataTable.Rows[listBox1.SelectedIndex][61].ToString();
            destData2.Text = dataTable.Rows[listBox1.SelectedIndex][62].ToString();
            destData3.Text = dataTable.Rows[listBox1.SelectedIndex][63].ToString();
            activeSkill.Text = dataTable.Rows[listBox1.SelectedIndex][64].ToString();
            activeSkillLv.Text = dataTable.Rows[listBox1.SelectedIndex][65].ToString();
            activeSkillPer.Text = dataTable.Rows[listBox1.SelectedIndex][66].ToString();
            reqMP.Text = dataTable.Rows[listBox1.SelectedIndex][67].ToString();
            reqFP.Text = dataTable.Rows[listBox1.SelectedIndex][68].ToString();
            reqDisLv.Text = dataTable.Rows[listBox1.SelectedIndex][69].ToString();
            reSkill1.Text = dataTable.Rows[listBox1.SelectedIndex][70].ToString();
            reSkillLevel1.Text = dataTable.Rows[listBox1.SelectedIndex][71].ToString();
            reSkill2.Text = dataTable.Rows[listBox1.SelectedIndex][72].ToString();
            reSkillLevel2.Text = dataTable.Rows[listBox1.SelectedIndex][73].ToString();
            skillReadyType.Text = dataTable.Rows[listBox1.SelectedIndex][74].ToString();
            skillReady.Text = dataTable.Rows[listBox1.SelectedIndex][75].ToString();
            skillRange.Text = dataTable.Rows[listBox1.SelectedIndex][76].ToString();
            sfxElemental.Text = dataTable.Rows[listBox1.SelectedIndex][77].ToString();
            sfxObj.Text = dataTable.Rows[listBox1.SelectedIndex][78].ToString();
            sfxObj2.Text = dataTable.Rows[listBox1.SelectedIndex][79].ToString();
            sfxObj3.Text = dataTable.Rows[listBox1.SelectedIndex][80].ToString();
            sfxObj4.Text = dataTable.Rows[listBox1.SelectedIndex][81].ToString();
            sfxObj4.Text = dataTable.Rows[listBox1.SelectedIndex][82].ToString();
            useMotion.Text = dataTable.Rows[listBox1.SelectedIndex][83].ToString();
            circleTime.Text = dataTable.Rows[listBox1.SelectedIndex][84].ToString();
            skillTime.Text = dataTable.Rows[listBox1.SelectedIndex][85].ToString();
            exeTarget.Text = dataTable.Rows[listBox1.SelectedIndex][86].ToString();
            useChance.Text = dataTable.Rows[listBox1.SelectedIndex][87].ToString();
            spellRegion.Text = dataTable.Rows[listBox1.SelectedIndex][88].ToString();
            spellType.Text = dataTable.Rows[listBox1.SelectedIndex][89].ToString();
            referStat1.Text = dataTable.Rows[listBox1.SelectedIndex][90].ToString();
            referStat2.Text = dataTable.Rows[listBox1.SelectedIndex][91].ToString();
            referTarget1.Text = dataTable.Rows[listBox1.SelectedIndex][92].ToString();
            referTarget2.Text = dataTable.Rows[listBox1.SelectedIndex][93].ToString();
            referValue1.Text = dataTable.Rows[listBox1.SelectedIndex][94].ToString();
            referValue2.Text = dataTable.Rows[listBox1.SelectedIndex][95].ToString();
            skillType.Text = dataTable.Rows[listBox1.SelectedIndex][96].ToString();
            itemResistElectricity.Text = dataTable.Rows[listBox1.SelectedIndex][97].ToString();
            itemResistFire.Text = dataTable.Rows[listBox1.SelectedIndex][98].ToString();
            itemResistWind.Text = dataTable.Rows[listBox1.SelectedIndex][99].ToString();
            itemResistWater.Text = dataTable.Rows[listBox1.SelectedIndex][100].ToString();
            itemResistEarth.Text = dataTable.Rows[listBox1.SelectedIndex][101].ToString();
            evilDoing.Text = dataTable.Rows[listBox1.SelectedIndex][102].ToString();
            expertLv.Text = dataTable.Rows[listBox1.SelectedIndex][103].ToString();
            expertMax.Text = dataTable.Rows[listBox1.SelectedIndex][104].ToString();
            subDefine.Text = dataTable.Rows[listBox1.SelectedIndex][105].ToString();
            exp.Text = dataTable.Rows[listBox1.SelectedIndex][106].ToString();
            comboStyle.Text = dataTable.Rows[listBox1.SelectedIndex][107].ToString();
            flightspeed.Text = dataTable.Rows[listBox1.SelectedIndex][108].ToString();
            flightLRAngle.Text = dataTable.Rows[listBox1.SelectedIndex][109].ToString();
            flightTBAngle.Text = dataTable.Rows[listBox1.SelectedIndex][110].ToString();
            flightLimit.Text = dataTable.Rows[listBox1.SelectedIndex][111].ToString();
            fFuelReMax.Text = dataTable.Rows[listBox1.SelectedIndex][112].ToString();
            afuelReMax.Text = dataTable.Rows[listBox1.SelectedIndex][113].ToString();
            fuelRe.Text = dataTable.Rows[listBox1.SelectedIndex][114].ToString();
            limitLevel1.Text = dataTable.Rows[listBox1.SelectedIndex][115].ToString();
            reflect.Text = dataTable.Rows[listBox1.SelectedIndex][116].ToString();
            sndAttack1.Text = dataTable.Rows[listBox1.SelectedIndex][117].ToString();
            sndAttack2.Text = dataTable.Rows[listBox1.SelectedIndex][118].ToString();
            icon.Text = dataTable.Rows[listBox1.SelectedIndex][119].ToString();
            questID.Text = dataTable.Rows[listBox1.SelectedIndex][120].ToString();
            textFile.Text = dataTable.Rows[listBox1.SelectedIndex][121].ToString();
            comment.Text = dataTable.Rows[listBox1.SelectedIndex][122].ToString();
        }
    }
}
