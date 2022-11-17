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
                echo 'Cleaning the solution'
                bat 'dotnet clean AccountOwnerServer.sln'
            }
        }

        stage ('Build Solution') {
            steps {
                echo 'Building the solution'
                bat 'dotnet build AccountOwnerServer.sln'
            }
        }

        stage ('Deploy Solution') {
            steps {
                echo 'Deploying solution to target Folder'
                echo 'Creating deploy folder in root'
                bat 'mkdir deploy'
                bat 'mkdir publishArtifacts'
                bat 'mkdir published'

                echo 'Publishing the solution'
                bat 'dotnet publish --self-contained --runtime  win-x64 -c Release  AccountOwnerServer.sln -o ./deploy'

                fileOperations([fileZipOperation(folderPath: 'deploy', outputFolderPath: 'publishArtifacts')])
                fileUnZipOperation(filePath: 'publishArtifacts', targetLocation: 'published')])
            }
        }
    }
}
