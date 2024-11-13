using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAdds : MonoBehaviour
{
    [Header("Timer")]
    [SerializeField] private float curTime = 0f;
    [SerializeField] private float spawnInterval = 1f;

    [Header("Ads")]
    [SerializeField] private List<GameObject> adList = new List<GameObject>();
    [SerializeField] private float minX, minY, maxX, maxY;
    [SerializeField] RectTransform canvas;
    [SerializeField] private List<GameObject> ads = new List<GameObject>();

    [Header("Cookies")]
    [SerializeField] public bool isAccepted = false;
    [SerializeField] private GameObject cookieBanner;

    // Start is called before the first frame update
    void Start()
    {
        var canvasSize = canvas.rect.size;
        maxX = canvasSize.x;
        maxY = canvasSize.y;
    }

    // Update is called once per frame
    void Update()
    {
        curTime += Time.deltaTime;
        if (curTime > spawnInterval)
        {
            curTime = 0f;
            int rand = Random.Range(0, adList.Count);
            GameObject currentAd = Instantiate(adList[rand]);
            ads.Add(currentAd);
            RectTransform adRect = currentAd.GetComponent<RectTransform>();
            adRect.SetParent(canvas);
            adRect.localScale = Vector3.one;
            Vector2 adSize = adRect.sizeDelta;
            var xpos = Random.Range(minX, maxX - adSize.x);
            var ypos = Random.Range(minY,  -maxY+adSize.y);
            adRect.anchoredPosition = new Vector2(xpos, ypos);
        }
    }

    public void SetSpawnRate(float spawnRate)
    {
        spawnInterval = spawnRate;
    }

    public void ShowCookies()
    {
        cookieBanner.SetActive(!isAccepted);

        for (int i = ads.Count - 1; i >= 0; i--)
        {
            ads[i].SetActive(false);
        }
    }

    public void SetCookies(bool state)
    {
        isAccepted = state;
    }

    public void CloseApp()
    {
        Application.Quit();
    }

    public void CloseTab()
    {
        for (int i = ads.Count - 1;i >= 0;i--)
        {
            ads[i].SetActive(false);
        }
    }
}
