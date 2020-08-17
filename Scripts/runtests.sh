
echo about to run tests
/Applications/Unity/Unity.app/Contents/MacOS/Unity -runTests -batchmode -testPlatform playmode -projectPath /Users/travis/build/alan-turing-institute/Unity-ci-travis/

echo run tests hopefully - now check output xml
echo `ls *.xml`
output=`grep "One or more child tests had errors" *.xml`
outputlen=${#output}

if [ $outputlen -gt 0 ]; then
    return -1
fi
