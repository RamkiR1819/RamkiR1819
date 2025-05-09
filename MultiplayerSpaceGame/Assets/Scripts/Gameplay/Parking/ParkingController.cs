using UnityEngine;

public class ParkingController : MonoBehaviour
{
    public Transform parkingSpot; // The designated parking spot
    public float parkingSpeed = 5f; // Speed at which the vehicle parks
    private bool isParking = false;

    void Update()
    {
        if (isParking)
        {
            ParkVehicle();
        }
    }

    public void StartParking()
    {
        isParking = true;
    }

    private void ParkVehicle()
    {
        // Move the vehicle towards the parking spot
        transform.position = Vector3.MoveTowards(transform.position, parkingSpot.position, parkingSpeed * Time.deltaTime);

        // Check if the vehicle has reached the parking spot
        if (Vector3.Distance(transform.position, parkingSpot.position) < 0.1f)
        {
            isParking = false;
            // Additional logic for when parking is complete can be added here
        }
    }
}