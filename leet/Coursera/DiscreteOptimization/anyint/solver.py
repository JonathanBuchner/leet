#!/usr/bin/python
# -*- coding: utf-8 -*-

def solve_it(inputData):
    Location = ""
    problemName = "AnyInt"

    # Write inputData to a temporary file
    # tmpFileName = 'tmp.data'
    # tmpFile = open(tmpFileName, 'w')
    # tmpFile.write(inputData)
    # tmpFile.close()


    # Run the command: 
    
    process = Popen(['java', 'Solver', '-file='+tmpFileName], stdout=PIPE)
    #process = Popen(['java', 'Solver', '-file='+tmpFileName], stdout=PIPE)
    #process = Popen(['octave', '--no-line-editing', '--silent', 'knap1.m', tmpFileName], stdout=PIPE)
    #process = Popen(['./BranchBound', tmpFileName], stdout=PIPE)
    #process = Popen(['python3', 'mysolver.py', tmpFileName], stdout=PIPE)
    #process = Popen(['kts', 'knapsack.kts', tmpFileName], stdout=PIPE)
    (stdout, stderr) = process.communicate()

    # remove the temporary file

    os.remove(tmpFileName)

    return stdout.strip()


if __name__ == '__main__':
    print('This script submits the integer: %s\n' % solve_it(''))

