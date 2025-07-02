



IAM roles:
edit role of codepipline
1.codepipline rolesploicies
AmazonS3FullAccess
AWSCodeDeployFullAccess
AWSCodePipeline_FullAccess

2.CodeBuildRole (attach to codebuild project)

AmazonEC2ContainerRegistryFullAccess
AmazonEC2ContainerRegistryPowerUser
AmazonS3FullAccess
AWSCodeBuildDeveloperAccess
CloudWatchFullAccess
CloudWatchFullAccessV2

3.CodeDeployEC2Role (attach to the instance role)
AmazonEC2RoleforAWSCodeDeploy
AmazonS3ReadOnlyAccess

4.CodeDeployServiceRole (code deploy service role)
AWSCodeDeployRole

5.CodePipelineServiceRole (pipeline service role)
AmazonS3FullAccess
AWSCodeDeployFullAccess
AWSCodePipeline_FullAccess
