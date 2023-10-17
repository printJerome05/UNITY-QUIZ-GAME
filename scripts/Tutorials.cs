using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorials : MonoBehaviour
{
    public GameObject RulesPanel;
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public GameObject panel5;
    public GameObject panel6;

    //LOAD RULES PANEL IN TUTORIAL
    public void LoadRulesPanel()
    {
        RulesPanel.SetActive(true);
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(false);
        panel5.SetActive(false);
        panel6.SetActive(false);
    }

    //LOAD PANEL1 IN TUTORIAL
    public void LoadPanel1()
    {
        RulesPanel.SetActive(false);
        panel1.SetActive(true);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(false);
        panel5.SetActive(false);
        panel6.SetActive(false);
        
    }

    //LOAD PANEL2 IN TUTORIAL
    public void LoadPanel2()
    {
        RulesPanel.SetActive(false);
        panel1.SetActive(false);
        panel2.SetActive(true);
        panel3.SetActive(false);
        panel4.SetActive(false);
        panel5.SetActive(false);
        panel6.SetActive(false);
    }

    //LOAD PANEL3 IN TUTORIAL
    public void LoadPanel3()
    {
        RulesPanel.SetActive(false);
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(true);
        panel4.SetActive(false);
        panel5.SetActive(false);
        panel6.SetActive(false);
    }

    //LOAD PANEL4 IN TUTORIAL
    public void LoadPanel4()
    {
        RulesPanel.SetActive(false);
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(true);
        panel5.SetActive(false);
        panel6.SetActive(false);
    }

    //LOAD PANEL5 IN TUTORIAL
    public void LoadPanel5()
    {
        RulesPanel.SetActive(false);
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(false);
        panel5.SetActive(true);
        panel6.SetActive(false);
    }

    //LOAD PANEL6 IN TUTORIAL
    public void LoadPanel6()
    {
        RulesPanel.SetActive(false);
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(false);
        panel5.SetActive(false);
        panel6.SetActive(true);
    }


    public void BackToRulesPanel()
    {
        RulesPanel.SetActive(true);
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(false);
        panel5.SetActive(false);
        panel6.SetActive(false);
    }

    public void BackToPanel1()
    {
        RulesPanel.SetActive(false);
        panel1.SetActive(true);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(false);
        panel5.SetActive(false);
        panel6.SetActive(false);

    }

    public void BackToPanel2()
    {
        RulesPanel.SetActive(false);
        panel1.SetActive(false);
        panel2.SetActive(true);
        panel3.SetActive(false);
        panel4.SetActive(false);
        panel5.SetActive(false);
        panel6.SetActive(false);
    }

    public void BackToPanel3()
    {
        RulesPanel.SetActive(false);
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(true);
        panel4.SetActive(false);
        panel5.SetActive(false);
        panel6.SetActive(false);
    }

    public void BackToPanel4()
    {
        RulesPanel.SetActive(false);
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(true);
        panel5.SetActive(false);
        panel6.SetActive(false);
    }

    public void BackToPanel5()
    {
        RulesPanel.SetActive(false);
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(false);
        panel5.SetActive(true);
        panel6.SetActive(false);
    }
}
