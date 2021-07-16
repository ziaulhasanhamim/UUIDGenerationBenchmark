package main

import (
    "testing"
)

func BenchmarkCreateuuid(b *testing.B) {
    for i := 0; i < b.N; i++ {
        _ = CreateUuid()
    }
}

func BenchmarkCreateuuidstring(b *testing.B) {
    for i := 0; i < b.N; i++ {
        _ = CreateUuidString()
    }
}
