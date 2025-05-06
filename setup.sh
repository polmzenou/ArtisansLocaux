#!/bin/bash

echo "=== Suppression de l'ancienne base artisans.db ==="
rm -f ArtisansLocaux/artisans.db

echo "=== Application des migrations ==="
dotnet ef database update --project ArtisansLocaux

echo "=== Lancement de l'application (avec seed) ==="
dotnet run --project ArtisansLocaux
