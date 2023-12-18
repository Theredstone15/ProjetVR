using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class CodePrincipal : MonoBehaviour
{
    public GameObject PieceCentrale;
    public GameObject AmpouleVerte1;
    public GameObject AmpouleRouge1;
    public AudioSource Complete;
    public AudioSource Bang;

    public GameObject PetitCercle;
    public GameObject MoyenCercle;
    public GameObject GrandCercle;

    public GameObject AmpouleVerte3;

    public GameObject AmpouleRouge3;

    public HingeJoint Symbole1;

    public HingeJoint Symbole2;

    public HingeJoint Symbole3;

    public HingeJoint Symbole4;

    public GameObject AmpouleVerteSymboles;

    public GameObject AmpouleRougeSymboles;

    public HingeJoint AiguilleMinutes;

    public HingeJoint AiguilleHeures;

    public GameObject AmpouleVerteHorloge;

    public GameObject AmpouleRougeHorloge;

    public GameObject Cle;
    


    private bool Puzzle1 = false;

    private bool Puzzle2 = false;

    private bool Puzzle3 = false;

    private bool Puzzle4 = false;

    private bool Puzzles = false;

    
    public void checkpuzzles(){

    
        
        if(Puzzle1 == false && PieceCentrale.transform.eulerAngles.x <= 0.39){
        AmpouleVerte1.SetActive(true);
        AmpouleRouge1.SetActive(false);
        Complete.Play();
        Puzzle1 = true;
        CheckVictory();
        } 

        if(Puzzle2 == false && (PetitCercle.transform.eulerAngles.x - MoyenCercle.transform.eulerAngles.x) <= 5 && (PetitCercle.transform.eulerAngles.x - GrandCercle.transform.eulerAngles.x) <= 5 && (MoyenCercle.transform.eulerAngles.x - GrandCercle.transform.eulerAngles.x) <= 5){
            AmpouleVerte3.SetActive(true);
            AmpouleRouge3.SetActive(false);
            Complete.Play();
            PetitCercle.transform.eulerAngles = new Vector3(90,0,0);
            MoyenCercle.transform.eulerAngles = new Vector3(90,0,0);
            GrandCercle.transform.eulerAngles = new Vector3(90,0,0);
            Puzzle2 = true;
            CheckVictory();
        }

        if(Puzzle3 == false && Symbole1.angle >=25 && Symbole1.angle <= 93 && Symbole2.angle <= -28 && Symbole2.angle >= -94 && (Symbole3.angle >= 150 || Symbole3.angle <= -150) && Symbole4.angle <= 150 && Symbole4.angle >= 93){
            Complete.Play();
            Puzzle3 = true;
            AmpouleVerteSymboles.SetActive(true);
            AmpouleRougeSymboles.SetActive(false); 
            CheckVictory();
        }

        if(Puzzle4 == false && AiguilleHeures.angle >= 133 && AiguilleHeures.angle <= 163 && AiguilleMinutes.angle <= -45 && AiguilleMinutes.angle >= -73){
            Complete.Play();
            Puzzle4 = true;
            AmpouleVerteHorloge.SetActive(true);
            AmpouleRougeHorloge.SetActive(false); 
            CheckVictory();
        }
    }

    private void CheckVictory(){
        if(Puzzle1 == true && Puzzle2 == true && Puzzle3 == true && Puzzle4 == true){
                Bang.Play();
                Cle.SetActive(true);
                print("Solved" );
            } else {
                print("1" + Puzzle1);
                print("2" + Puzzle2);
                print("3" + Puzzle3);
                print("4" + Puzzle4);
            }
    }

    public void Win(){
        SceneManager.LoadScene("Escape");
    }
}