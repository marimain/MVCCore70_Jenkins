pipeline {
    agent any

    stages {
      stage ('Clean workspace') {
        steps {
          cleanWs()
        }
      }
      stage ('Git Checkout') {
        steps {
            git branch: 'main',  credentialsId:'f3de8d23-ae66-427f-a339-50df0a740664',url: 'git@github.com:marimain/MVCCore70_Jenkins.git'
          }
        }
        stage('Restore packages') {
          steps {

            bat 'dotnet build C:\\ProgramData\\Jenkins\\.jenkins\\workspace\\MVCCore70_Jenkins\\MVCCore70_Jenkins.sln --configuration Release'
          }
        }
     stage('Publish'){
            steps{
            bat "dotnet publish C:\\ProgramData\\Jenkins\\.jenkins\\workspace\\MVCCore70_Jenkins\\MVCCore70_Jenkins.sln "
        }
     }
    }
}
