¿Cómo buildear el Dockerfile?
==========
dotnet publish -c Release
docker build -t <eltag> .

Extra
==========
Para futura adaptación a kubernetes y su configuracion revisar este link:
https://medium.com/@fbeltrao/automatically-reload-configuration-changes-based-on-kubernetes-config-maps-in-a-net-d956f8c8399a