require 'TestCase'
require 'WasRun'

class TestCaseTest < TestCase
	def setUp
		super
		@test=WasRun.new("testMethod")
	end
	
	def testTemplateMethod
		test=WasRun.new("testMethod")
		test.run
		assert("setUp testMethod tearDown"==test.log)
	end
	
	def testResult
		test = WasRun.new("testMethod")
		result = test.run()
		assert("1 run, 0 failed"==result.summary)
	end
	
end
