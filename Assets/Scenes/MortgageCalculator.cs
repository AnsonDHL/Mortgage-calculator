using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MortgageCalculator : MonoBehaviour
{

    public TMP_InputField MortgageAmount;
    public TMP_InputField InterestRate;
    public TMP_InputField Amortization;
    public TextMeshProUGUI MonthlyPayment;

    public void CalculateMonthlyPayment()
    {
        float mortgagefloat = float.Parse(MortgageAmount.text);
        float interestratefloat = float.Parse(InterestRate.text);
        float amortizationfloat = float.Parse(Amortization.text);

        double r = double.Parse(InterestRate.text) * 12 / 100;
        double n = double.Parse(Amortization.text) * 12;

        double MonthlyPaymentFloat = mortgagefloat * (1 + r) / n ;

        MonthlyPayment.text = MonthlyPaymentFloat.ToString();


    }
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
