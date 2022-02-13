using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DateCheck : MonoBehaviour
{
    System.DateTime now;
    int oldMonth;
    int oldDay;
    int oldDayOfYear;
    int nowMonth;
    int nowDay;
    public AudioClip voice_date0101;
    public AudioClip voice_date0;
    public AudioClip voice_date1;
    public AudioClip voice_date2;
    public AudioClip voice_date3;
    public AudioClip voice_date4;
    public AudioClip voice_date5;
    public AudioClip voice_date6;
    public AudioClip voice_date7;
    public AudioClip voice_date8;
    public AudioClip voice_date9;
    public AudioClip voice_date10;
    public AudioClip voice_date11;
    public AudioClip voice_date12;
    public AudioClip voice_date13;
    public AudioClip voice_date14;
    public AudioClip voice_date15;
    public AudioClip voice_date16;
    public AudioClip voice_date17;
    public AudioClip voice_date18;
    public AudioClip voice_date19;
    public AudioClip voice_date20;
    public AudioClip voice_date21;
    public AudioClip voice_date22;
    public AudioClip voice_date23;
    public AudioClip voice_date24;
    public AudioClip voice_date25;
    public AudioClip voice_date26;
    public AudioClip voice_date27;
    public AudioClip voice_date28;
    public AudioClip voice_date29;
    public AudioClip voice_date30;
    public AudioClip voice_date31;
    public AudioClip voice_date32;
    public AudioClip voice_date33;
    public AudioClip voice_date34;
    public AudioClip voice_date35;
    public AudioClip voice_date36;
    public AudioClip voice_date37;
    public AudioClip voice_date38;
    public AudioClip voice_date39;
    public AudioClip voice_date40;
    public AudioClip voice_date41;
    public AudioClip voice_date42;
    public AudioClip voice_date43;
    public AudioClip voice_date44;
    public AudioClip voice_date45;
    public AudioClip voice_date46;
    public AudioClip voice_date47;
    public AudioClip voice_date48;
    public AudioClip voice_date49;
    public AudioClip voice_date50;
    public AudioClip voice_date51;
    public AudioClip[] voice_date;
    private AudioSource univoice;
    // Start is called before the first frame update
    void Start()
    {
        voice_date = new AudioClip[52];
        voice_date[0] = voice_date0;
        voice_date[1] = voice_date1;
        voice_date[2] = voice_date2;
        voice_date[3] = voice_date3;
        voice_date[4] = voice_date4;
        voice_date[5] = voice_date5;
        voice_date[6] = voice_date6;
        voice_date[7] = voice_date7;
        voice_date[8] = voice_date8;
        voice_date[9] = voice_date9;
        voice_date[10] = voice_date10;
        voice_date[11] = voice_date11;
        voice_date[12] = voice_date12;
        voice_date[13] = voice_date13;
        voice_date[14] = voice_date14;
        voice_date[15] = voice_date15;
        voice_date[16] = voice_date16;
        voice_date[17] = voice_date17;
        voice_date[18] = voice_date18;
        voice_date[19] = voice_date19;
        voice_date[20] = voice_date20;
        voice_date[21] = voice_date21;
        voice_date[22] = voice_date22;
        voice_date[23] = voice_date23;
        voice_date[24] = voice_date24;
        voice_date[25] = voice_date25;
        voice_date[26] = voice_date26;
        voice_date[27] = voice_date27;
        voice_date[28] = voice_date28;
        voice_date[29] = voice_date29;
        voice_date[30] = voice_date30;
        voice_date[31] = voice_date31;
        voice_date[32] = voice_date32;
        voice_date[33] = voice_date33;
        voice_date[34] = voice_date34;
        voice_date[35] = voice_date35;
        voice_date[36] = voice_date36;
        voice_date[37] = voice_date37;
        voice_date[38] = voice_date38;
        voice_date[39] = voice_date39;
        voice_date[40] = voice_date40;
        voice_date[41] = voice_date41;
        voice_date[42] = voice_date42;
        voice_date[43] = voice_date43;
        voice_date[44] = voice_date44;
        voice_date[45] = voice_date45;
        voice_date[46] = voice_date46;
        voice_date[47] = voice_date47;
        voice_date[48] = voice_date48;
        voice_date[49] = voice_date49;
        voice_date[50] = voice_date50;
        voice_date[51] = voice_date51;
        oldMonth = PlayerPrefs.GetInt("Month");
        oldDay = PlayerPrefs.GetInt("Day");
        oldDayOfYear = PlayerPrefs.GetInt("DayOfYear");
        Debug.Log("이전 실행일 : " + oldMonth + "월" + oldDay + "일" + oldDayOfYear + "일 째");
        now = System.DateTime.Now;
        nowMonth = now.Month;
        nowDay = now.Day;
        PlayerPrefs.SetInt("Month", nowMonth);
        PlayerPrefs.SetInt("Day", nowDay);
        PlayerPrefs.SetInt("DayOfYear", now.DayOfYear);
        univoice = GetComponent<AudioSource>();
        if (oldDayOfYear != now.DayOfYear)
        {
            univoice.PlayOneShot(voice_date[now.DayOfYear / 7]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
