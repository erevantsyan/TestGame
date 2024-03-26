using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtLvl : MonoBehaviour
{
    public TMP_Text textFind;
    [SerializeField] private int sec = 5;
    [SerializeField] private int delta = 1;

    public Animator animButt0_1;
    [SerializeField] private bool animButtAns0_1;
    public Animator animButt1_1;
    [SerializeField] private bool animButtAns1_1;
    public Animator animButt2_1;
    [SerializeField] private bool animButtAns2_1;

    public Animator animButt0_2;
    [SerializeField] private bool animButtAns0_2;
    public Animator animButt1_2;
    [SerializeField] private bool animButtAns1_2;
    public Animator animButt2_2;
    [SerializeField] private bool animButtAns2_2;
    public Animator animButt3_2;
    [SerializeField] private bool animButtAns3_2;
    public Animator animButt4_2;
    [SerializeField] private bool animButtAns4_2;
    public Animator animButt5_2;
    [SerializeField] private bool animButtAns5_2;

    public Animator animButt0_3;
    [SerializeField] private bool animButtAns0_3;
    public Animator animButt1_3;
    [SerializeField] private bool animButtAns1_3;
    public Animator animButt2_3;
    [SerializeField] private bool animButtAns2_3;
    public Animator animButt3_3;
    [SerializeField] private bool animButtAns3_3;
    public Animator animButt4_3;
    [SerializeField] private bool animButtAns4_3;
    public Animator animButt5_3;
    [SerializeField] private bool animButtAns5_3;
    public Animator animButt6_3;
    [SerializeField] private bool animButtAns6_3;
    public Animator animButt7_3;
    [SerializeField] private bool animButtAns7_3;
    public Animator animButt8_3;
    [SerializeField] private bool animButtAns8_3;

    private Coroutine  currentCoroutine;

    [SerializeField]
    private int count = 0;

    public GameObject lvl1;

    public GameObject lvl2;

    public GameObject lvl3;

    public GameObject restartButt;
    public GameObject TxtF;

    public GameObject FinishGame;

    public MainLvl1 ml1;

    public MainLvl2 ml2;

    public MainLvl3 ml3;


    void Update()
    {
    }
    public void Butt0(){
        if (StaticCount.TrueAns == 0 && count == 0 && StaticCount.lvlCount == 0)
        {
            count = 1;
            sec = 5;
            StaticCount.lvlCount += 1;
            currentCoroutine = StartCoroutine(ITimer());
            animButtAns0_1 = true;
            animButt0_1.SetBool("AnsButt0", animButtAns0_1);
            animButt1_1.enabled = false;
            animButt2_1.enabled = false;
        }
        if (StaticCount.TrueAns != 0 && count == 0 && StaticCount.lvlCount == 0){
        animButtAns0_1 = false;
        animButt0_1.SetBool("AnsButt0", animButtAns0_1);
        }
        if (StaticCount.TrueAns == 0 && count == 0 && StaticCount.lvlCount == 1)
        {
            count = 1;
            sec = 5;
            StaticCount.lvlCount += 1;
            currentCoroutine = StartCoroutine(ITimer());
            animButtAns0_2 = true;
            animButt0_2.SetBool("AnsButt0_2", animButtAns0_2);
            animButt1_2.enabled = false;
            animButt2_2.enabled = false;
            animButt3_2.enabled = false;
            animButt4_2.enabled = false;
            animButt5_2.enabled = false;
        }
        if (StaticCount.TrueAns != 0 && count == 0 && StaticCount.lvlCount == 1){
        animButtAns0_2 = false;
        animButt0_2.SetBool("AnsButt0_2", animButtAns0_2);
        }
        if (StaticCount.TrueAns == 0 && count == 0 && StaticCount.lvlCount == 2)
        {
            count = 1;
            sec = 5;
            StaticCount.lvlCount += 1;
            currentCoroutine = StartCoroutine(ITimer());
            animButtAns0_3 = true;
            animButt0_3.SetBool("AnsButt0_3", animButtAns0_3);
            animButt1_3.enabled = false;
            animButt2_3.enabled = false;
            animButt3_3.enabled = false;
            animButt4_3.enabled = false;
            animButt5_3.enabled = false;
            animButt6_3.enabled = false;
            animButt7_3.enabled = false;
            animButt8_3.enabled = false;
        }
        if (StaticCount.TrueAns != 0 && count == 0 && StaticCount.lvlCount == 2){
        animButtAns0_3 = false;
        animButt0_3.SetBool("AnsButt0_3", animButtAns0_3);
        }
    }

    public void Butt1(){
        if (StaticCount.TrueAns == 1 && count == 0 && StaticCount.lvlCount == 0)
        {
            count = 1;
            sec = 5;
            StaticCount.lvlCount += 1;
            currentCoroutine = StartCoroutine(ITimer());
            animButtAns1_1 = true;
            animButt1_1.SetBool("AnsButt1", animButtAns1_1);
            animButt0_1.enabled = false;
            animButt2_1.enabled = false;
        }
        if (StaticCount.TrueAns != 1 && count == 0 && StaticCount.lvlCount == 0){
        animButtAns1_1 = false;
        animButt1_1.SetBool("AnsButt1", animButtAns1_1);
        }
        if (StaticCount.TrueAns == 1 && count == 0 && StaticCount.lvlCount == 1)
        {
            count = 1;
            sec = 5;
            StaticCount.lvlCount += 1;
            currentCoroutine = StartCoroutine(ITimer());
            animButtAns1_2 = true;
            animButt1_2.SetBool("AnsButt1_2", animButtAns1_2);
            animButt0_2.enabled = false;
            animButt2_2.enabled = false;
            animButt3_2.enabled = false;
            animButt4_2.enabled = false;
            animButt5_2.enabled = false;
        }
        if (StaticCount.TrueAns != 1 && count == 0 && StaticCount.lvlCount == 1){
        animButtAns1_2 = false;
        animButt1_2.SetBool("AnsButt1_2", animButtAns1_2);
        }
        if (StaticCount.TrueAns == 1 && count == 0 && StaticCount.lvlCount == 2)
        {
            count = 1;
            sec = 5;
            StaticCount.lvlCount += 1;
            currentCoroutine = StartCoroutine(ITimer());
            animButtAns1_3 = true;
            animButt1_3.SetBool("AnsButt1_3", animButtAns1_3);
            animButt0_3.enabled = false;
            animButt2_3.enabled = false;
            animButt3_3.enabled = false;
            animButt4_3.enabled = false;
            animButt5_3.enabled = false;
            animButt6_3.enabled = false;
            animButt7_3.enabled = false;
            animButt8_3.enabled = false;
        }
        if (StaticCount.TrueAns != 1 && count == 0 && StaticCount.lvlCount == 2){
        animButtAns1_3 = false;
        animButt1_3.SetBool("AnsButt1_3", animButtAns1_3);
        }
    }

    public void Butt2(){
        if (StaticCount.TrueAns == 2 && count == 0 && StaticCount.lvlCount == 0)
        {
            count = 1;
            sec = 5;
            StaticCount.lvlCount += 1;
            currentCoroutine = StartCoroutine(ITimer());
            animButtAns2_1 = true;
            animButt2_1.SetBool("AnsButt2", animButtAns2_1);
            animButt0_1.enabled = false;
            animButt1_1.enabled = false;
        }
        if (StaticCount.TrueAns != 2 && count == 0 && StaticCount.lvlCount == 0){
        animButtAns2_1 = false;
        animButt2_1.SetBool("AnsButt2", animButtAns2_1);
        }
        if (StaticCount.TrueAns == 2 && count == 0 && StaticCount.lvlCount == 1)
        {
            count = 1;
            sec = 5;
            StaticCount.lvlCount += 1;
            currentCoroutine = StartCoroutine(ITimer());
            animButtAns2_2 = true;
            animButt2_2.SetBool("AnsButt2_2", animButtAns2_2);
            animButt0_2.enabled = false;
            animButt1_2.enabled = false;
            animButt3_2.enabled = false;
            animButt4_2.enabled = false;
            animButt5_2.enabled = false;
        }
        if (StaticCount.TrueAns != 2 && count == 0 && StaticCount.lvlCount == 1){
        animButtAns2_2 = false;
        animButt2_2.SetBool("AnsButt2_2", animButtAns2_2);
        }
        if (StaticCount.TrueAns == 2 && count == 0 && StaticCount.lvlCount == 2)
        {
            count = 1;
            sec = 5;
            StaticCount.lvlCount += 1;
            currentCoroutine = StartCoroutine(ITimer());
            animButtAns2_3 = true;
            animButt2_3.SetBool("AnsButt2_3", animButtAns2_3);
            animButt0_3.enabled = false;
            animButt1_3.enabled = false;
            animButt3_3.enabled = false;
            animButt4_3.enabled = false;
            animButt5_3.enabled = false;
            animButt6_3.enabled = false;
            animButt7_3.enabled = false;
            animButt8_3.enabled = false;
        }
        if (StaticCount.TrueAns != 2 && count == 0 && StaticCount.lvlCount == 2){
        animButtAns2_3 = false;
        animButt2_3.SetBool("AnsButt2_3", animButtAns2_3);
        }
    }

    public void Butt3(){
        if (StaticCount.TrueAns == 3 && count == 0 && StaticCount.lvlCount == 1)
        {
            count = 1;
            sec = 5;
            StaticCount.lvlCount += 1;
            currentCoroutine = StartCoroutine(ITimer());
            animButtAns3_2 = true;
            animButt3_2.SetBool("AnsButt3_2", animButtAns3_2);
            animButt0_2.enabled = false;
            animButt1_2.enabled = false;
            animButt2_2.enabled = false;
            animButt4_2.enabled = false;
            animButt5_2.enabled = false;
        }
        if (StaticCount.TrueAns != 3 && count == 0 && StaticCount.lvlCount == 1){
        animButtAns3_2 = false;
        animButt3_2.SetBool("AnsButt3_2", animButtAns3_2);
        }
        if (StaticCount.TrueAns == 3 && count == 0 && StaticCount.lvlCount == 2)
        {
            count = 1;
            sec = 5;
            StaticCount.lvlCount += 1;
            currentCoroutine = StartCoroutine(ITimer());
            animButtAns3_3 = true;
            animButt3_3.SetBool("AnsButt3_3", animButtAns3_3);
            animButt0_3.enabled = false;
            animButt1_3.enabled = false;
            animButt2_3.enabled = false;
            animButt4_3.enabled = false;
            animButt5_3.enabled = false;
            animButt6_3.enabled = false;
            animButt7_3.enabled = false;
            animButt8_3.enabled = false;
        }
        if (StaticCount.TrueAns != 3 && count == 0 && StaticCount.lvlCount == 2){
        animButtAns3_3 = false;
        animButt3_3.SetBool("AnsButt3_3", animButtAns3_3);
        }
    }

    public void Butt4(){
        if (StaticCount.TrueAns == 4 && count == 0 && StaticCount.lvlCount == 1)
        {
            count = 1;
            sec = 5;
            StaticCount.lvlCount += 1;
            currentCoroutine = StartCoroutine(ITimer());
            animButtAns4_2 = true;
            animButt4_2.SetBool("AnsButt4_2", animButtAns4_2);
            animButt0_2.enabled = false;
            animButt1_2.enabled = false;
            animButt2_2.enabled = false;
            animButt3_2.enabled = false;
            animButt5_2.enabled = false;
        }
        if (StaticCount.TrueAns != 4 && count == 0 && StaticCount.lvlCount == 1){
        animButtAns4_2 = false;
        animButt4_2.SetBool("AnsButt4_2", animButtAns4_2);
        }
        if (StaticCount.TrueAns == 4 && count == 0 && StaticCount.lvlCount == 2)
        {
            count = 1;
            sec = 5;
            StaticCount.lvlCount += 1;
            currentCoroutine = StartCoroutine(ITimer());
            animButtAns4_3 = true;
            animButt4_3.SetBool("AnsButt4_3", animButtAns4_3);
            animButt0_3.enabled = false;
            animButt1_3.enabled = false;
            animButt2_3.enabled = false;
            animButt3_3.enabled = false;
            animButt5_3.enabled = false;
            animButt6_3.enabled = false;
            animButt7_3.enabled = false;
            animButt8_3.enabled = false;
        }
        if (StaticCount.TrueAns != 4 && count == 0 && StaticCount.lvlCount == 2){
        animButtAns4_3 = false;
        animButt4_3.SetBool("AnsButt4_3", animButtAns4_3);
        }
    }

    public void Butt5(){
        if (StaticCount.TrueAns == 5 && count == 0 && StaticCount.lvlCount == 1)
        {
            count = 1;
            sec = 5;
            StaticCount.lvlCount += 1;
            currentCoroutine = StartCoroutine(ITimer());
            animButtAns5_2 = true;
            animButt5_2.SetBool("AnsButt5_2", animButtAns5_2);
            animButt0_2.enabled = false;
            animButt1_2.enabled = false;
            animButt2_2.enabled = false;
            animButt3_2.enabled = false;
            animButt4_2.enabled = false;
        }
        if (StaticCount.TrueAns != 5 && count == 0 && StaticCount.lvlCount == 1){
        animButtAns5_2 = false;
        animButt5_2.SetBool("AnsButt5_2", animButtAns5_2);
        }
        if (StaticCount.TrueAns == 5 && count == 0 && StaticCount.lvlCount == 2)
        {
            count = 1;
            sec = 5;
            StaticCount.lvlCount += 1;
            currentCoroutine = StartCoroutine(ITimer());
            animButtAns5_3 = true;
            animButt5_3.SetBool("AnsButt5_3", animButtAns5_3);
            animButt0_3.enabled = false;
            animButt1_3.enabled = false;
            animButt2_3.enabled = false;
            animButt3_3.enabled = false;
            animButt4_3.enabled = false;
            animButt6_3.enabled = false;
            animButt7_3.enabled = false;
            animButt8_3.enabled = false;
        }
        if (StaticCount.TrueAns != 5 && count == 0 && StaticCount.lvlCount == 2){
        animButtAns5_3 = false;
        animButt5_3.SetBool("AnsButt5_3", animButtAns5_3);
        }
    }

    public void Butt6(){
        if (StaticCount.TrueAns == 6 && count == 0 && StaticCount.lvlCount == 2)
        {
            count = 1;
            sec = 5;
            StaticCount.lvlCount += 1;
            currentCoroutine = StartCoroutine(ITimer());
            animButtAns6_3 = true;
            animButt6_3.SetBool("AnsButt6_3", animButtAns6_3);
            animButt0_3.enabled = false;
            animButt1_3.enabled = false;
            animButt2_3.enabled = false;
            animButt3_3.enabled = false;
            animButt4_3.enabled = false;
            animButt5_3.enabled = false;
            animButt7_3.enabled = false;
            animButt8_3.enabled = false;
        }
        if (StaticCount.TrueAns != 6 && count == 0 && StaticCount.lvlCount == 2){
        animButtAns6_3 = false;
        animButt6_3.SetBool("AnsButt6_3", animButtAns6_3);
        }
    }

    public void Butt7(){
        if (StaticCount.TrueAns == 7 && count == 0 && StaticCount.lvlCount == 2)
        {
            count = 1;
            sec = 5;
            StaticCount.lvlCount += 1;
            currentCoroutine = StartCoroutine(ITimer());
            animButtAns7_3 = true;
            animButt7_3.SetBool("AnsButt7_3", animButtAns7_3);
            animButt0_3.enabled = false;
            animButt1_3.enabled = false;
            animButt2_3.enabled = false;
            animButt3_3.enabled = false;
            animButt4_3.enabled = false;
            animButt5_3.enabled = false;
            animButt6_3.enabled = false;
            animButt8_3.enabled = false;
        }
        if (StaticCount.TrueAns != 7 && count == 0 && StaticCount.lvlCount == 2){
        animButtAns7_3 = false;
        animButt7_3.SetBool("AnsButt7_3", animButtAns7_3);
        }
    }

    public void Butt8(){
        if (StaticCount.TrueAns == 8 && count == 0 && StaticCount.lvlCount == 2)
        {
            count = 1;
            sec = 5;
            StaticCount.lvlCount += 1;
            currentCoroutine = StartCoroutine(ITimer());
            animButtAns8_3 = true;
            animButt8_3.SetBool("AnsButt8_3", animButtAns8_3);
            animButt0_3.enabled = false;
            animButt1_3.enabled = false;
            animButt2_3.enabled = false;
            animButt3_3.enabled = false;
            animButt4_3.enabled = false;
            animButt5_3.enabled = false;
            animButt6_3.enabled = false;
            animButt7_3.enabled = false;
        }
        if (StaticCount.TrueAns != 8 && count == 0 && StaticCount.lvlCount == 2){
        animButtAns8_3 = false;
        animButt8_3.SetBool("AnsButt8_3", animButtAns8_3);
        }
    }

    public void RestartB(){
        StaticCount.lvlCount = 0;
        ml1.count = 0;
        ml2.count = 0;
        ml3.count = 0;
        lvl1.SetActive (true);
        restartButt.SetActive (false);
        TxtF.SetActive (true);
        FinishGame.SetActive (false);
    }

    IEnumerator ITimer()
    {
        while (true)
        {
            sec -= delta;
            if (sec <= 0)
            {
                if (StaticCount.lvlCount == 1)
                {
                    StaticCount.rotationCount = 1;
                    animButt0_1.enabled = true;
                    animButt1_1.enabled = true;
                    animButt2_1.enabled = true;
                    lvl1.SetActive (false);
                    lvl2.SetActive (true);
                    for (int i = 0; i < 2; i++)
                    {
                        if (ml1.indexnum[i] != -1)
                        {
                            Quaternion pos = Quaternion.Euler(0, 0, 0);
                            ml1.itemTransform[ml1.indexnum[i]].rotation = pos;
                        }
                    }
                }
                if (StaticCount.lvlCount == 2)
                {
                    StaticCount.rotationCount = 2;
                    animButt0_2.enabled = true;
                    animButt1_2.enabled = true;
                    animButt2_2.enabled = true;
                    animButt3_2.enabled = true;
                    animButt4_2.enabled = true;
                    animButt5_2.enabled = true;
                    lvl2.SetActive (false);
                    lvl3.SetActive (true);
                    for (int i = 0; i < 2; i++)
                    {
                        if (ml2.indexnum[i] != -1)
                        {
                            Quaternion pos = Quaternion.Euler(0, 0, 0);
                            ml2.itemTransform[ml2.indexnum[i]].rotation = pos;
                        }
                    }
                } 
                if (StaticCount.lvlCount == 3)
                {
                    StaticCount.rotationCount = 3;
                    animButt0_3.enabled = true;
                    animButt1_3.enabled = true;
                    animButt2_3.enabled = true;
                    animButt3_3.enabled = true;
                    animButt4_3.enabled = true;
                    animButt5_3.enabled = true;
                    animButt6_3.enabled = true;
                    animButt7_3.enabled = true;
                    animButt8_3.enabled = true;
                    TxtF.SetActive (false);
                    FinishGame.SetActive (true);
                    lvl3.SetActive (false);
                    restartButt.SetActive (true);
                    for (int i = 0; i < 2; i++)
                    {
                        if (ml3.indexnum[i] != -1)
                        {
                            Quaternion pos = Quaternion.Euler(0, 0, 0);
                            ml3.itemTransform[ml3.indexnum[i]].rotation = pos;
                        }
                    }
                }
                count = 0;
                stopCurrentCoroutine();
            }
            yield return new WaitForSeconds(1);
        }
    }

    void stopCurrentCoroutine() {
    if( currentCoroutine != null ) {
        StopCoroutine( currentCoroutine );
        currentCoroutine = null;
    }
    }
}
