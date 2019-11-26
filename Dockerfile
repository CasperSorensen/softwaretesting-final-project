FROM microsoft/dotnet:latest
COPY . /softwaretesting-final-project
WORKDIR /softwaretesting-final-project/app
RUN dotnet restore
EXPOSE 5000/tcp
ENTRYPOINT [ "dotnet", "run", "--no-restore", "--urls", "http://0.0.0.0:5000"]
