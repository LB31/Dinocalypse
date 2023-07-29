using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private PlayerMover BigPlayerMover;
    [SerializeField] private PlayerInteractor BiggerPlayerInteractor;
    [SerializeField] private GameObject CameraBig;
    [SerializeField] private GameObject CameraSmall;

    [SerializeField] private PlayerMover SmallPlayerMover;
    [SerializeField] private PlayerInteractor SmallPlayerInteractor;

    private async void Start()
    {
        await Task.Delay(1500);
        SmallPlayerMover.enabled = false;
        SmallPlayerInteractor.enabled = false;
        CameraSmall.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            BigPlayerMover.enabled = !BigPlayerMover.enabled;
            BiggerPlayerInteractor.enabled = !BiggerPlayerInteractor.enabled;
            SmallPlayerMover.enabled = !SmallPlayerMover.enabled;
            SmallPlayerInteractor.enabled = !SmallPlayerInteractor.enabled;
            CameraBig.SetActive(!CameraBig.activeSelf);
            CameraSmall.SetActive(!CameraSmall.activeSelf);

            BigPlayerMover.transform.parent = null;
            SmallPlayerMover.transform.parent = null;
        }

    }


}
