pipeline {
    agent any
    stages {
        stage ('Stage 1') {
            steps {
                echo 'This is the Stage 1 from Jenkinsfile'
            }
        }
        stage ('Clean workspace') {
            steps {
                echo 'Clean Workspace'
                cleanWs()
            }
        }
        stage ('Git Checkout') {
            steps {
                echo 'Checkout the source code from Github'
                git branch: 'master', url: 'https://github.com/fjsevillamora/AccountOwnerServer.git'
            }
        }
        stage ('Restore NuGet Packages') {
            steps {
                echo 'Restoring NuGet Packages'
                bat 'dotnet restore AccountOwnerServer.sln'
            }
        }
        stage ('Clean Solution') {
            steps {
                echo 'Cleaning the solution using MSBuild.exe'
                bat 'dotnet clean AccountOwnerServer.sln'
            }
        }
    }
}
