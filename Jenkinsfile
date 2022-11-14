stage ('Clean workspace') {
    steps {
        echo 'Clean Workspace'
        cleanWs()
    }
}
stage ('Git Checkout') {
    steps {
        echo 'Checkout the source code from Github'
        git branch: '*/master', url: 'https://github.com/fjsevillamora/AccountOwnerServer'
    }
}