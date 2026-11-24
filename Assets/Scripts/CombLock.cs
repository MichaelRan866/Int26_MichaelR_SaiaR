using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class CombLock : MonoBehaviour
{
    private int[] combination;
    public TextMeshProUGUI[] numDisplays;

    public string correctCombo;


    private bool IsCorrectCombo()
    {
        for (int i = 0; i < correctCombo.Length; i++)
        {
            if (!combination[i].ToString().Equals(correctCombo.Substring(i, 1)))
                return false;
        }

        return true;
    }

    public void IncreaseDigit(int index)
    {
        combination[index]++;
        if (combination[index] >= 10)
            combination[index] = 0;
    }
    
    public void DecreaseDigit(int index)
    {
        combination[index]--;
        if (combination[index] < 0)
            combination[index] = 9;
    }
}
