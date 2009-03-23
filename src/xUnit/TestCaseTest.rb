require 'TestCase'
require 'WasRun'

class TestCaseTest < TestCase
	def setUp
		super
		@test=WasRun.new("testMethod")
	end
	def testSetup	
		@test.run
		assert(@test.wasSetup)
	end
	def testRunning
		@test.run
		assert(@test.wasRun)
	end
end
