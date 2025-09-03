$buildFolder = (Get-Item -Path '.\' -Verbose).FullName + "\bin\"
Remove-Item $buildFolder -Recurse -ErrorAction Ignore

docker build -t newunderwriting -f Dockerfile .
docker run -p 80:80 

