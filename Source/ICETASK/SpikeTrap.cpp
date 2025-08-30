// Fill out your copyright notice in the Description page of Project Settings.

#include "TimeManager.h"
#include "BP_BaseCharacter.h"
#include "SpikeTrap.h"
#include "Kismet/GameplayStatics.h"

// Sets default values
ASpikeTrap::ASpikeTrap()
{
 	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;
	SpikeMesh = CreateDefaultSubobject<UStaticMeshComponent>(TEXT("Spike Mesh"));

}

// Called when the game starts or when spawned
void ASpikeTrap::BeginPlay()
{
	Super::BeginPlay();
	SpikeMesh->OnComponentHit.AddDynamic(this, &ASpikeTrap::OnComponentHit);
}

// Called every frame
void ASpikeTrap::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

}

void ASpikeTrap::OnComponentHit(UPrimitiveComponent* HitComponent, Actor* OtherActor, UPrimitiveComponent* OtherComp, FVector NormalImpulse, const FHitResult& Hit)
{
	if (ABP_BaseCharacter* OurChar = Cast<ABP_BaseCharacter>(OtherActor)) 
	{
		OurChar->LaunchCharacter(FVector(1000, 1000, 1000), true, true);
		GetWorldTimerManager().SetTimer(RestartTimer, this, &ASpikeTrap::HandleReset, 3.f);
	}
}

void ASpikeTrap::HandleReset()
{
	Fname LevelName = Fname(UGameplayStatics::GetCurrentLevelName(GetWorld()));
	UGameplayStatics::OpenLevel(GetWorld(), LevelName);

	UGameplayStatics::OpenLevel()
}

