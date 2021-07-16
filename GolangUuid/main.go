package main

import (
	"github.com/google/uuid"
)

func CreateUuid() uuid.UUID {
	return uuid.New();
}

func CreateUuidString() string {
	id := uuid.New()
	return id.String()
}
