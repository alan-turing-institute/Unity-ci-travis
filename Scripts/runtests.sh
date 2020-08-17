
echo about to run tests
/Applications/Unity/Unity.app/Contents/MacOS/Unity -runTests -batchmode -testPlatform playmode -projectPath $UNITY_PROJECT_DIR

echo run tests hopefully - now check output xml
echo `ls ${UNITY_PROJECT_DIR}/*.xml`
output=`grep "One or more child tests had errors" ${UNITY_PROJECT_DIR}/*.xml`
outputlen=${#output}

if [ $outputlen -gt 0 ]; then
    retcode=44
else
    retcode=0
fi

exit $retcode
