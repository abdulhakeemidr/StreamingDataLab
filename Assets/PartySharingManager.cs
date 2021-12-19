using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartySharingManager : MonoBehaviour
{
    public GameObject enterSharingRoomButton, sharingRoomNameText, 
        sharingRoomInputField, sendPartyButton;

    public NetworkedClient networkClient;

    void Start()
    {
        enterSharingRoomButton.GetComponent<Button>().onClick.AddListener(JoinSharingRoomButtonPressed);
        sendPartyButton.GetComponent<Button>().onClick.AddListener(SendPartyButtonPressed);

        networkClient = GetComponent<NetworkedClient>();
    }

    void Update()
    {
        
    }

    void JoinSharingRoomButtonPressed()
    {
        string name = sharingRoomInputField.GetComponent<InputField>().text;
        networkClient.SendMessageToHost(ClientToServerSignifiers.JoinSharingRoom+ "," + name);
    }

    void SendPartyButtonPressed()
    {
        AssignmentPart2.SendOnScreenPartyToServerForSharing(networkClient);
    }
}
