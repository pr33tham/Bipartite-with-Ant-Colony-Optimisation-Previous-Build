using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : MonoBehaviour {

    /*
         * Iteration starts
        [1] Calculte Desirability
        [2] Turn towards the goal
        [3] HandlePheramonePlacement
        [4] Move to new City
        [5] add city to visited
        [5] Go to Step 1
        [6] update gloabl pheramone?
         * Iteration stops
    */


    //Only an Agent that moves around cities instead of biological ants
    //Can implement later
    public enum State { searchingSetA, searchingSetB };
    public Transform pheramoneDepositPos;

    List<City> visitedCities;

    [SerializeField] GameObject CityGen;
    public float desirabilityThreshold= 1f;
    Graph<City> cityGraph;

    private void Start() {
        cityGraph = CityGen.GetComponent<CityGenerator>().graph; 
    }



    private void Update() {
        
    }


    private float ProbabilityForCityIJ(float pheramoneDespositLevelIJ, float costIJ,
        float alpha, float beta) {

    }


}